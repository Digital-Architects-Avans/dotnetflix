using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Movie;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Movies;

public class MovieRepository: IMovieRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;
    
    public MovieRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }
    
    public async Task<IEnumerable<Movie>> GetMovies()
    {
        var movies = await _dotNetFlixDbContext.Movies.ToListAsync();
        return movies;
    }

    public async Task<Movie> GetMovie(int id)
    {
        var movie = await _dotNetFlixDbContext.Movies.SingleOrDefaultAsync(m => m.Id == id);
        return movie;
    }

    public async Task<Movie> AddMovie(AddMovieDto addMovieDto)
    {
        var movie = new Movie
        {
            Title = addMovieDto.Title,
            Year = addMovieDto.Year,
            Description = addMovieDto.Description,
            Rating = addMovieDto.Rating,
            Runtime =  addMovieDto.Runtime,
            Image = addMovieDto.Image
        };
        
        var result = await _dotNetFlixDbContext.Movies.AddAsync(movie);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Movie> UpdateMovie(int id, UpdateMovieDto updateMovieDto)
    {
        var movie = await _dotNetFlixDbContext.Movies.FindAsync(id);

        if (movie != null)
        {
            movie.Title = updateMovieDto.Title;
            movie.Year = updateMovieDto.Year;
            movie.Description = updateMovieDto.Description;
            movie.Rating = updateMovieDto.Rating;
            movie.Runtime = updateMovieDto.Runtime;
            movie.Image = updateMovieDto.Image;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return movie;
        }

        return null;
    }

    public async Task<Movie> DeleteMovie(int id)
    {
        var movie = await _dotNetFlixDbContext.Movies.FindAsync(id);

        if (movie != null)
        {
            _dotNetFlixDbContext.Movies.Remove(movie);
            await _dotNetFlixDbContext.SaveChangesAsync();
        }

        return movie;
    }
}