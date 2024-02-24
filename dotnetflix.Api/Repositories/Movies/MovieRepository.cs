using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Movies;

public class MovieRepository: IMovieRepository
{
    private readonly DotNetFlixDbContext dotNetFlixDbContext;
    public MovieRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        this.dotNetFlixDbContext = dotNetFlixDbContext;
    }
    public async Task<IEnumerable<Movie>> GetMovies()
    {
        var movies = await this.dotNetFlixDbContext.Movies.ToListAsync();
        return movies;
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