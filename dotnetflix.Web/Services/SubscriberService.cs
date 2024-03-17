using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Subscriber;
using dotnetflix.Web.Services.Contracts;
using System.Net.Http.Json;

namespace dotnetflix.Web.Services;

public class SubscriberService : ISubscriberService
{
    private readonly HttpClient _httpClient;

    public async Task<IEnumerable<SubscriberDto>?> GetSubscribers()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<SubscriberDto>>("api/Subscriber");
            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
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
            {
                // success
                return true;
            }

        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        return false;
    }
}

