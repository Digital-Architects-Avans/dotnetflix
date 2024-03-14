using dotnetflix.Models.Dtos.Movie;

namespace dotnetflix.Web.Services.Contracts;

public interface IMovieService
{
    Task<MovieDto?> GetMovie(int id);
}