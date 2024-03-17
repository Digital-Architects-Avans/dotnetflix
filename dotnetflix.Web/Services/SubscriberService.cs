using dotnetflix.Models.Dtos.Subscriber;
using dotnetflix.Web.Services.Contracts;
using System.Net.Http.Json;

namespace dotnetflix.Web.Services;

public class SubscriberService : ISubscriberService
{
    private readonly HttpClient _httpClient;

    public SubscriberService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<SubscriberDto>?> GetSubscribers()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<SubscriberDto>>("api/Subscriber");
            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
    public async Task<bool> AddSubscriber(AddSubscriberDto newSubscriber)
    {
        var addSubscriberDto = new AddSubscriberDto
        {
            Name = newSubscriber.Name,
            Email = newSubscriber.Email
        };

        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/Subscriber", addSubscriberDto);

            if (response.IsSuccessStatusCode)
                return true;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine(ex);
            throw;
        }
        return false;
    }

    public async Task<bool> DeleteSubscriber(int  id)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"api/Subscriber/{id}");

            if (response.IsSuccessStatusCode)
                return true;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine(ex);
            throw;
        }
        return false;
    }
}

