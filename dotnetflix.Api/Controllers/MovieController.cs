using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Movies;
using Microsoft.AspNetCore.Mvc;
using dotnetflix.Models.Dtos.Movie;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MovieController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
    {
        try
        {
            var movies = await _movieRepository.GetMovies();
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MovieDto>> GetMovie(int id)
    {
        try
        {
            var movie = await _movieRepository.GetMovie(id);
            return Ok(movie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<MovieDto>> AddMovie([FromBody] AddMovieDto addMovieDto)
    {
        try
        {
            var newMovie = await _movieRepository.AddMovie(addMovieDto);
            if (newMovie == null)
            {
                return NoContent();
            }

            var newMovieDto = newMovie.ConvertToDto();
            return Ok(newMovieDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<MovieDto>> UpdateMovie(int id, UpdateMovieDto updateMovieDto)
    {
        try
        {
            var updatedMovie = await _movieRepository.UpdateMovie(id, updateMovieDto);
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
            var movie = await _movieRepository.DeleteMovie(id);
            return Ok(movie);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}