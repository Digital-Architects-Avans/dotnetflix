using dotnetflix.Models.Dtos;
using dotnetflix.Web.Services.Contracts;
using System.Net.Http.Json;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Seat;
using dotnetflix.Models.Dtos.TheaterRow;
using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Web.Services;

public class TicketService : ITicketService
{
    private readonly HttpClient _httpClient;

    public TicketService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<TicketDto>?> GetTickets()
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Ticket");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<TicketDto>();
                }

                return await response.Content.ReadFromJsonAsync<IEnumerable<TicketDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception(message);
            }
        }
        catch (Exception e)
        {
            // Log Exception
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<IEnumerable<TicketTypeDto>> GetTicketTypes()
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/TicketType");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<TicketTypeDto>();
                }

                return await response.Content.ReadFromJsonAsync<IEnumerable<TicketTypeDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception(message);
            }
        }
        catch (Exception e)
        {
            // Log Exception
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<IEnumerable<TicketDto>> GetTicketsForShow(int showId)
    {
        var response = await _httpClient.GetAsync($"api/Ticket/Show/{showId}");

        if (response.IsSuccessStatusCode)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return Enumerable.Empty<TicketDto>();
            }

            return await response.Content.ReadFromJsonAsync<IEnumerable<TicketDto>>();
        }
        else
        {
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
    }

    private async Task<IEnumerable<SeatDto>> GetAllSeatsForTheater(int theaterId)
    {
        var response = await _httpClient.GetAsync($"api/Seat/Theater/{theaterId}");

        if (response.IsSuccessStatusCode)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return Enumerable.Empty<SeatDto>();
            }

            return await response.Content.ReadFromJsonAsync<IEnumerable<SeatDto>>();
        }
        else
        {
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
    }

    private async Task<IEnumerable<TheaterRowDto>> GetAllTheaterRowsForTheater(int theaterId)
    {
        var response = await _httpClient.GetAsync($"api/TheaterRows/Theater/{theaterId}");

        if (response.IsSuccessStatusCode)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return Enumerable.Empty<TheaterRowDto>();
            }

            return await response.Content.ReadFromJsonAsync<IEnumerable<TheaterRowDto>>();
        }
        else
        {
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
    }

    public Dictionary<int, int[]> CalculateSeatWorth(IEnumerable<TheaterRowDto> theaterRows)
    {
        var seatWorthMap = new Dictionary<int, int[]>();

        // Find the middle row for bonus worth calculation
        int maxRowNumber = theaterRows.Max(row => row.RowNumber);
        int middleRowNumber = maxRowNumber / 2;

        foreach (var row in theaterRows.OrderBy(r => r.RowNumber))
        {
            var seatWorths = new int[row.NumberOfSeats];

            // Calculate the middle seat index for this row
            int middleSeatIndex = row.NumberOfSeats / 2;
            for (int seatIndex = 0; seatIndex < row.NumberOfSeats; seatIndex++)
            {
                // Calculate distance from the middle seat in the row
                int distanceFromMiddleSeat = Math.Abs(seatIndex - middleSeatIndex);

                // Calculate distance from the middle row in the theater
                int distanceFromMiddleRow = Math.Abs(row.RowNumber - middleRowNumber);

                // Calculate the seat's worth - further from the middle reduces the worth
                // Assuming basic worth calculation, can be adjusted as needed
                int seatWorth = (maxRowNumber - distanceFromMiddleRow) + (row.NumberOfSeats - distanceFromMiddleSeat);

                seatWorths[seatIndex] = seatWorth;
            }

            seatWorthMap.Add(row.RowNumber, seatWorths);
        }

        return seatWorthMap;
    }

    public async Task<IEnumerable<SeatDto>> GetAvailableSeatsForShow(int showId, int theaterId)
    {
        // Fetches all seats for the theater
        var allSeats = await GetAllSeatsForTheater(theaterId);

        // Get all the tickets sold for the show using the TicketService
        var soldTickets = await GetTicketsForShow(showId);

        // Extract sold seat IDs from the tickets
        var soldSeatIds = soldTickets.Select(ticket => ticket.SeatId).ToList();

        // Determine and return available seats by filtering out the sold seats
        var availableSeats = allSeats.Where(seat => !soldSeatIds.Contains(seat.Id)).ToList();

        return availableSeats;
    }

    public async Task<IEnumerable<SeatDto>> SelectBestAvailableSeats(int showId, int theaterId, int quantity)
    {
        //Todo: Implement the logic to select the best available seats
        // For now just select the first available seats

        var availableSeats = await GetAvailableSeatsForShow(showId, theaterId);

        // Group available seats by row
        var groupedByRow = availableSeats.GroupBy(seat => seat.RowNumber)
            .OrderBy(group => group.Key); // Optional: Order by row number for consistency

        foreach (var rowGroup in groupedByRow)
        {
            // Convert the group to a list and try to find a sequence of 'quantity' seats
            var seatsInRow =
                rowGroup.OrderBy(seat => seat.SeatNumber).ToList(); // Ensure seats are ordered by their number

            for (int i = 0; i <= seatsInRow.Count - quantity; i++)
            {
                // Check if the next 'quantity' seats are sequential
                var isSequential = true;
                for (int j = 1; j < quantity; j++)
                {
                    if (seatsInRow[i + j - 1].SeatNumber + 1 != seatsInRow[i + j].SeatNumber)
                    {
                        isSequential = false;
                        break;
                    }
                }

                if (isSequential)
                {
                    // Found a sequence of 'quantity' seats, return them
                    return seatsInRow.Skip(i).Take(quantity).ToList();
                }
            }
        }

        // If no contiguous block of 'quantity' seats was found in any row, return an empty list
        return new List<SeatDto>();
    }

    public async Task<List<TicketDto>> GenerateTickets(OrderRequestDto orderRequest)
    {
        List<TicketDto> generatedTickets = new List<TicketDto>();

        foreach (var ticketOrder in orderRequest.TicketOrders)
        {
            // Select the best available seats for the quantity specified in the ticket order
            var bestAvailableSeats =
                await SelectBestAvailableSeats(ticketOrder.ShowId, ticketOrder.TheaterId, ticketOrder.Quantity);
            // Use the using statement for automatic disposal of the enumerator
            using (var seatEnumerator = bestAvailableSeats.GetEnumerator())
            {
                for (int i = 0; i < ticketOrder.Quantity; i++)
                {
                    // Move to the next available seat
                    if (!seatEnumerator.MoveNext())
                    {
                        throw new Exception(
                            $"Not enough seats available for show ID {ticketOrder.ShowId} at theater ID {ticketOrder.TheaterId}");
                    }

                    // Create a new ticket for each quantity with the assigned seat
                    var newTicket = new TicketDto
                    {
                        ShowId = ticketOrder.ShowId,
                        Movie = ticketOrder.MovieTitle,
                        TheaterName = ticketOrder.TheaterName,
                        ShowTime = ticketOrder.ShowTime,
                        SeatId = seatEnumerator.Current.Id, // Assign the selected seat ID
                        RowNumber = seatEnumerator.Current.RowNumber,
                        SeatNumber = seatEnumerator.Current.SeatNumber,
                        TicketTypeId = ticketOrder.TicketTypeId,
                        TicketPrice = ticketOrder.FinalPrice
                    };

                    // Post the newTicket to your API to save it in the database
                    var response = await _httpClient.PostAsJsonAsync($"api/Ticket", newTicket);
                    if (response.IsSuccessStatusCode)
                    {
                        var createdTicket = await response.Content.ReadFromJsonAsync<TicketDto>();
                        generatedTickets.Add(createdTicket);
                    }
                    else
                    {
                        var message = await response.Content.ReadAsStringAsync();
                        throw new Exception($"Failed to generate ticket: {message}");
                    }
                }
            }
        }

        return generatedTickets;
    }
}