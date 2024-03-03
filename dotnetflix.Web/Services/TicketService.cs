using dotnetflix.Models.Dtos;
using dotnetflix.Web.Services.Contracts;
using System.Net.Http.Json;
using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Web.Services;

public class TicketService : ITicketService
{
    private readonly HttpClient _httpClient;
    
    public TicketService(HttpClient httpClient) 
    { 
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<TicketDto>> GetTickets()
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
}
