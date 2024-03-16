using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Subscriber;
using System.Net.Http.Json;

namespace dotnetflix.Web.Services;

public class SubscriberService
{
    private readonly HttpClient _httpClient;

    public async Task<IEnumerable<SubscriberDto>?> GetSubscribers()
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Subscriber");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    return Enumerable.Empty<SubscriberDto>();

                return await response.Content.ReadFromJsonAsync<IEnumerable<SubscriberDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception(message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public async Task<AddSubscriberDto> AddSubscriber(AddSubscriberDto newSubscriber)
    {
        var addSubscriberDto = new AddSubscriberDto
        {
            Name = newSubscriber.Name,
            Email = newSubscriber.Email
        };

        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/Subscriber", addSubscriberDto);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
                return await Task.FromResult(addSubscriberDto);
            
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        return null;
    }
}

