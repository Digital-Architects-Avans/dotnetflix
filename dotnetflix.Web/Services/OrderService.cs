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
            var order = await this._httpClient.GetFromJsonAsync<OrderDto>($"api/Order/{id}");
            return order ?? new OrderDto();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}