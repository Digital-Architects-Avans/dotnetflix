using System.Net.Http.Json;
using dotnetflix.Models.Dtos.Seat;
using dotnetflix.Models.Dtos.Show;
using dotnetflix.Models.Dtos.TheaterRow;

namespace dotnetflix.Web.Services.Contracts;

public class SeatService : ISeatService
{
    private readonly HttpClient _httpClient;
    private readonly ITicketService _ticketService;

    public SeatService(HttpClient httpClient, ITicketService ticketService)
    {
        _httpClient = httpClient;
        _ticketService = ticketService;
    }
    
    public async Task<IEnumerable<SeatDto>?> GetAllSeatsForTheater(int theaterId)
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

    public async Task<IEnumerable<TheaterRowDto>?> GetAllTheaterRowsForTheater(int theaterId)
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
        var theaterRowDtos = theaterRows as TheaterRowDto[] ?? theaterRows.ToArray();
        var maxRowNumber = theaterRowDtos.Max(row => row.RowNumber);
        var middleRowNumber = maxRowNumber / 2;

        foreach (var row in theaterRowDtos.OrderBy(r => r.RowNumber))
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

    public async Task<IEnumerable<SeatDto>?> GetAvailableSeatsForShow(int showId)
    {
        var show = await _httpClient.GetFromJsonAsync<ShowDto>($"api/Show/{showId}");

        if (show != null)
        {
            // Fetches all seats for the theater
            var allSeats = await GetAllSeatsForTheater(show.TheaterId);
            
            // Get all the tickets sold for the show using the TicketService
            var soldTickets = await _ticketService.GetTicketsForShow(showId);

            // Extract sold seat IDs from the tickets
            var soldSeatIds = soldTickets.Select(ticket => ticket.SeatId).ToList();

            // Determine and return available seats by filtering out the sold seats
            var availableSeats = allSeats?.Where(seat => !soldSeatIds.Contains(seat.Id)).ToList();

            return availableSeats;
        }

        throw new Exception($"Show with ID {showId} not found");
    }

    // public async Task<IEnumerable<SeatDto>> SelectBestAvailableSeats(int showId, int quantity)
    // {
    //     //Todo: Implement the logic to select the best available seats
    //     // For now just select the first available seats
    //
    //     var availableSeats = await GetAvailableSeatsForShow(showId);
    //
    //     if(availableSeats == null)
    //     {
    //         throw new Exception("No available seats found for the show");
    //     }
    //     
    //     // Group available seats by row
    //     var groupedByRow = availableSeats
    //         .GroupBy(seat => seat.RowNumber)
    //         .OrderBy(group => group.Key); // Optional: Order by row number for consistency
    //
    //     foreach (var rowGroup in groupedByRow)
    //     {
    //         // Convert the group to a list and try to find a sequence of 'quantity' seats
    //         var seatsInRow =
    //             rowGroup.OrderBy(seat => seat.SeatNumber).ToList(); // Ensure seats are ordered by their number
    //
    //         for (int i = 0; i <= seatsInRow.Count - quantity; i++)
    //         {
    //             // Check if the next 'quantity' seats are sequential
    //             var isSequential = true;
    //             for (int j = 1; j < quantity; j++)
    //             {
    //                 if (seatsInRow[i + j - 1].SeatNumber + 1 != seatsInRow[i + j].SeatNumber)
    //                 {
    //                     isSequential = false;
    //                     break;
    //                 }
    //             }
    //
    //             if (isSequential)
    //             {
    //                 // Found a sequence of 'quantity' seats, return them
    //                 return seatsInRow.Skip(i).Take(quantity).ToList();
    //             }
    //         }
    //     }
    //
    //     // If no contiguous block of 'quantity' seats was found in any row, return an empty list
    //     return new List<SeatDto>();
    // }
    
}