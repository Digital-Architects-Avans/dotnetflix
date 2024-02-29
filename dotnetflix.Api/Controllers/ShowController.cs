using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Movies;
using dotnetflix.Api.Repositories.Shows;
using dotnetflix.Api.Repositories.Theaters;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Show;
using dotnetflix.Models.Dtos.Theater;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShowController : ControllerBase
{
    private readonly IShowRepository _showRepository;
    private readonly IMovieRepository _movieRepository;
    private readonly ITheaterRepository _theaterRepository;

    public ShowController(IShowRepository showRepository, IMovieRepository movieRepository,
        ITheaterRepository theaterRepository)
    {
        _showRepository = showRepository;
        _movieRepository = movieRepository;
        _theaterRepository = theaterRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ShowDto>>> GetShows()
    {
        try
        {
            var shows = await _showRepository.GetShows();
            if (shows == null)
            {
                return NotFound();
            }

            var movies = await _movieRepository.GetMovies();
            if (movies == null)
            {
                throw new Exception("No movies exists in the system");
            }

            var theaters = await _theaterRepository.GetTheaters();
            if (theaters == null)
            {
                throw new Exception("No theaters exists in the system");
            }


            var showDtos = shows.ConvertToDto(movies, theaters);
            return Ok(showDtos);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ShowDto>> GetShow(int id)
    {
        try
        {
            var show = await _showRepository.GetShow(id);

            if (show == null)
            {
                return NotFound();
            }

            var showDto = show.ConvertToDto();

            return Ok(showDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ShowDto>> AddShow(AddShowDto addShowDto)
    {
        try
        {
            var newShow = await _showRepository.AddShow(addShowDto);
            if (newShow == null)
            {
                return NoContent();
            }

            var newShowDto = newShow.ConvertToDto();
            
            return Ok(newShowDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ShowDto>> UpdateShow(int id, UpdateShowDto updateShowDto)
    {
        try
        {
            var updatedShow = await _showRepository.UpdateShow(id, updateShowDto);

            if (updatedShow == null)
            {
                return NotFound();
            }

            var updatedShowDto = updatedShow.ConvertToDto();

            return Ok(updatedShowDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ShowDto>> DeleteShow(int id)
    {
        try
        {
            var show = await _showRepository.DeleteShow(id);

            if (show == null)
            {
                return NotFound();
            }
            
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}