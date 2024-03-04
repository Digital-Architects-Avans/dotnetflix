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


    public async Task<bool> VerifyPaymentSuccess(string orderId)
    {
        var response = await _httpClient.GetAsync($"Payment/verify/{orderId}");
        return response.IsSuccessStatusCode;
    }
    
    
    public async Task<OrderDto> CreateOrder(OrderRequestDto orderRequest)
    {
        // Use TicketService to generate tickets and get their IDs
        var tickets = await _ticketService.GenerateTickets(orderRequest).ConfigureAwait(false);

        // Prepare the data to be sent in the request
        var addOrderDto = new AddOrderDto
        {
            TicketIds = tickets.Select(t => t.Id).ToList() 
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