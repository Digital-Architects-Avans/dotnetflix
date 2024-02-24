using dotnetflix.Api.Data.Entities;

namespace dotnetflix.Api.Repositories.Movies;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetMovies();
    Task<Movie> GetMovie(int id);
    Task<Movie> AddMovie(Movie movie);
    Task<Movie> UpdateMovie(Movie movie);
    Task<Movie> DeleteMovie(int id);
}
