using dotnetflix.Models.Dtos;
using dotnetflix.Web.Services.Contracts;
using System.Net.Http.Json;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Supplement;
using dotnetflix.Models.Dtos.Ticket;
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
    
    public async Task<TicketDto?> GetTicket(int id)
    {
        try
        {
            var ticket = await _httpClient.GetFromJsonAsync<TicketDto>($"api/Ticket/{id}");
            return ticket ?? new TicketDto();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public async Task<IEnumerable<TicketDto>?> GetTicketsForOrder(int orderId)
    {
        var response = await _httpClient.GetAsync($"api/Ticket/Order/{orderId}");

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

    public async Task<IEnumerable<TicketTypeDto>?> GetTicketTypes()
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
    
    public async Task<IEnumerable<SupplementDto>?> GetSupplements()
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Supplement");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<SupplementDto>();
                }

                return await response.Content.ReadFromJsonAsync<IEnumerable<SupplementDto>>();
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

    public async Task<IEnumerable<TicketDto>?> GetTicketsForShow(int showId)
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

    public async Task<List<TicketDto>> GenerateTickets(OrderRequestDto orderRequest)
    {
        List<TicketDto> generatedTickets = new List<TicketDto>();

        foreach (var ticketOrder in orderRequest.TicketOrders)
        {
            // Todo: Add Seats based upon the seats in the OrderRequest (User Selection)
            for (int i = 0; i < ticketOrder.Quantity; i++)
            {
                // Create a new ticket for each quantity with the assigned seat
                var newTicket = new AddTicketDto
                {
                    ShowId = ticketOrder.ShowId,
                    SeatId = ticketOrder.SeatId, // Assign the selected seat ID
                    TicketTypeId = ticketOrder.TicketTypeId,
                    TicketPrice = ticketOrder.FinalPrice,
                    Supplements = ticketOrder.SupplementIds
                };

                // Post the newTicket to your API to save it in the database
                var response = await _httpClient.PostAsJsonAsync($"api/Ticket", newTicket);
                if (response.IsSuccessStatusCode)
                {
                    var createdTicket = await response.Content.ReadFromJsonAsync<TicketDto>();
                    if (createdTicket != null) generatedTickets.Add(createdTicket);
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Failed to generate ticket: {message}");
                }
            }
        }


        return generatedTickets;
    }
}