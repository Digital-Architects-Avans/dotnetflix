using dotnetflix.Models.Dtos;
using dotnetflix.Web.Services.Contracts;
using System.Net.Http.Json;

namespace dotnetflix.Web.Services;

public class TicketService : ITicketService
{
    private readonly HttpClient _httpClient;
    
    public TicketService(HttpClient httpClient) 
    { 
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<TicketDto>> GetItems()
    {
        try
        {
            var tickets = await _httpClient.GetFromJsonAsync<IEnumerable<TicketDto>>("api/Ticket");
            return tickets;
        }
        catch (Exception)
        {

            throw;
        }
    }
}
