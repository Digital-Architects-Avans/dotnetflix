using dotnetflix.Api.Data.Entities;

namespace dotnetflix.Api.Repositories.Movies;

public class MovieRepository: IMovieRepository
{
    public Task<IEnumerable<Movie>> GetMovies()
    {
        throw new NotImplementedException();
    }

    public Task<Movie> GetMovie(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> AddMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> UpdateMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> DeleteMovie(int id)
    {
        throw new NotImplementedException();
    }
}