using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Movies;
using dotnetflix.Models.Dtos;

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
            if (movies == null)
            {
                return NotFound();
            }
            else
            {
                var movieDtos = movies.ConvertToDto();
                return Ok(movieDtos);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, 
                "Error retrieving data from the database");
        }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<MovieDto>> GetMovie(int id)
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
    public async Task<ActionResult<MovieDto>> AddMovie(MovieDto movieDto)
    {
        try
        {
            var movie = movieDto.ConvertToEntity();
            var newMovie = await this.movieRepository.AddMovie(movie);
            return Ok(newMovie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPut]
    public async Task<ActionResult<MovieDto>> UpdateMovie(Movie movie)
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
    public async Task<ActionResult<MovieDto>> DeleteMovie(int id)
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