using dotnetflix.Models.Dtos.Movie;

namespace dotnetflix.Web.Services.Contracts;

public interface IMovieService
{
    Task<IEnumerable<MovieDto>?> GetMovie(int id);
}