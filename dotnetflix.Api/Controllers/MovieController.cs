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
    private readonly ILogger<MovieController> _logger;


    public MovieController(IMovieRepository movieRepository, ILogger<MovieController> logger)
    {
        _movieRepository = movieRepository;
        _logger = logger;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
    {
        try
        {
            var movies = await _movieRepository.GetMovies();
            var movieDtos = movies.ConvertToDto();
            return Ok(movieDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetMovies");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<MovieDto>> GetMovie(int id)
    {
        try
        {
            var movie = await _movieRepository.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            var movieDto = movie.ConvertToDto();

            return Ok(movieDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetMovie with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<MovieDto>> AddMovie([FromBody] AddMovieDto addMovieDto)
    {
        try
        {
            var newMovie = await _movieRepository.AddMovie(addMovieDto);

            var newMovieDto = newMovie.ConvertToDto();

            return CreatedAtAction(nameof(GetMovie), new { id = newMovieDto.Id }, newMovieDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddMovie");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<MovieDto>> UpdateMovie(int id, UpdateMovieDto updateMovieDto)
    {
        try
        {
            var updatedMovie = await _movieRepository.UpdateMovie(id, updateMovieDto);

            if (updatedMovie == null)
            {
                return NoContent();
            }

            var updatedMovieDto = updatedMovie.ConvertToDto();

            return Ok(updatedMovieDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for UpdateMovie with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteMovie(int id)
    {
        try
        {
            var movie = await _movieRepository.DeleteMovie(id);

            if (!movie)
            {
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for DeleteMovie with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}