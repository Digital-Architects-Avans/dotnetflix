using System.Net.Http.Json;
// using dotnetflix.Models.Dtos;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class MovieService : IMovieService
{
    private readonly HttpClient _httpClient;

    public MovieService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    /*
    public async Task<IEnumerable<MovieDto>> GetMovie(int id)
    {
        try
        {
            var movie = await this._httpClient.GetFromJsonAsync<MovieDto>($"api/Movie/{id}");
            // return movie;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    */
}