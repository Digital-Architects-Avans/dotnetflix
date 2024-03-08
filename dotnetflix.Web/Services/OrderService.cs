using System.Net.Http.Json;
using dotnetflix.Models.Dtos.Order;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class OrderService : IOrderService
{
    private readonly HttpClient _httpClient;
    private readonly ITicketService _ticketService;
    
    public OrderService(HttpClient httpClient, ITicketService ticketService)
    {
        _httpClient = httpClient;
        _ticketService = ticketService;
    }


    public Task<IEnumerable<OrderDto>> GetItems()
    {
        throw new NotImplementedException();
    }

    public async Task<OrderDto> GetOrder(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Order/{id}");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return default(OrderDto);
                }

                return await response.Content.ReadFromJsonAsync<OrderDto>();
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
            Console.WriteLine($"An error occurred: {e.Message}");
            return null;
        }
    }

    public async Task<bool> VerifyPaymentSuccess(string orderId)
    {
        var response = await _httpClient.GetAsync($"Payment/verify/{orderId}");
        return response.IsSuccessStatusCode;
    }
    
    public async Task<OrderDto?> GetOrderByUuid(string uuid)
    {
        var response = await _httpClient.GetAsync($"api/Order/uuid/{uuid}");

        if (response.IsSuccessStatusCode)
        {
            var order = await response.Content.ReadFromJsonAsync<OrderDto>();
            return order ?? throw new InvalidOperationException("Failed to deserialize the order.");
        }
        else
        {
            throw new Exception("Failed to retrieve order.");
        }
    }
    
    
    public async Task<OrderDto> CreateOrder(OrderRequestDto orderRequest)
    {
        // Use TicketService to generate tickets and get their IDs
        var tickets = await _ticketService.GenerateTickets(orderRequest).ConfigureAwait(false);
        
        // Generate a random 6 character code
        string orderCode = Path.GetRandomFileName().Replace(".", "").Substring(0, 6);

        // Prepare the data to be sent in the request
        var addOrderDto = new AddOrderDto
        {
            TicketIds = tickets.Select(t => t.Id).ToList(),
             Uuid= orderCode,
             CustomerEmail = orderRequest.CustomerEmail,
             CustomerName = orderRequest.CustomerName
        };

        // Attempt to save the order in the database
        var response = await _httpClient.PostAsJsonAsync($"api/Order", addOrderDto).ConfigureAwait(false);

        // Check the response status code
        if (!response.IsSuccessStatusCode)
        {
            // If the request was not successful, throw an exception with the error message
            var errorMessage = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new Exception($"Failed to generate order: {errorMessage}");
        }

        // Deserialize and return the created order object
        var createdOrder = await response.Content.ReadFromJsonAsync<OrderDto>().ConfigureAwait(false);
        return createdOrder ?? throw new InvalidOperationException("Failed to deserialize the created order.");
    }
}