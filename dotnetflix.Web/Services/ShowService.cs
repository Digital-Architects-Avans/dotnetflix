using System.Net.Http.Json;
// using dotnetflix.Models.Dtos;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class ShowService : IShowService
{
    private readonly HttpClient _httpClient;

    public ShowService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    /*
    public async Task<IEnumerable<ShowDto>> GetShows()
    {
        try
        {
            var shows = await this._httpClient.GetFromJsonAsync<IEnumerable<ShowDto>>("api/Show");
            // return shows;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    */
}