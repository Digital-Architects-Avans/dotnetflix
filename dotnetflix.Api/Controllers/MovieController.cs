using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Repositories.Movies;

namespace dotnetflix.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieRepository movieRepository;
    public MovieController(IMovieRepository movieRepository)
    {
        this.movieRepository = movieRepository;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
    {
        try
        {
            var movies = await this.movieRepository.GetMovies();
            return Ok(movies);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovie(int id)
    {
        try
        {
            var movie = await this.movieRepository.GetMovie(id);
            return Ok(movie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPost]
    public async Task<ActionResult<Movie>> AddMovie(Movie movie)
    {
        try
        {
            var newMovie = await this.movieRepository.AddMovie(movie);
            return Ok(newMovie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPut]
    public async Task<ActionResult<Movie>> UpdateMovie(Movie movie)
    {
        try
        {
            var updatedMovie = await this.movieRepository.UpdateMovie(movie);
            return Ok(updatedMovie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult<Movie>> DeleteMovie(int id)
    {
        try
        {
            var movie = await this.movieRepository.DeleteMovie(id);
            return Ok(movie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}