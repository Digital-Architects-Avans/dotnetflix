using System.Net.Http.Json;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Order;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class MovieService : IMovieService
{
    private readonly HttpClient _httpClient;

    public MovieService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<MovieDto?> GetMovie(int id)
    {
        try
        {
            var movie = await this._httpClient.GetFromJsonAsync<MovieDto>($"api/Movie/{id}");
            return movie ?? new MovieDto();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}