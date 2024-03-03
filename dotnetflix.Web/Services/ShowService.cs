using System.Net.Http.Json;
using dotnetflix.Models.Dtos.Show;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class ShowService : IShowService
{
    private readonly HttpClient _httpClient;

    public ShowService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<ShowDto>?> GetShows()
    {
        try
        {
            var shows = await _httpClient.GetFromJsonAsync<IEnumerable<ShowDto>>("api/Show");
            return shows;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public async Task<ShowDto>? GetShow(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Show/{id}");

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return default(ShowDto);
                }

                return await response.Content.ReadFromJsonAsync<ShowDto>();
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