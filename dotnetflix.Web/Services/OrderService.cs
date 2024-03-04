using System.Net.Http.Json;
using dotnetflix.Models.Dtos.Order;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class OrderService : IOrderService
{
    private readonly HttpClient _httpClient;

    public OrderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
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
}