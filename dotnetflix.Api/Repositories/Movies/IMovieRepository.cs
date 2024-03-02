using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Movie;

namespace dotnetflix.Api.Repositories.Movies;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetMovies();
    Task<Movie?> GetMovie(int id);
    Task<Movie> AddMovie(AddMovieDto addMovieDto);
    Task<Movie?> UpdateMovie(int id, UpdateMovieDto updateMovieDto);
    Task<bool> DeleteMovie(int id);
}
