using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Theaters;
using dotnetflix.Models.Dtos.Theater;

namespace dotnetflix.Api.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]
public class TheaterController : ControllerBase
{
    private readonly ITheaterRepository _theaterRepository;
    private readonly ILogger<TheaterController> _logger;

    public TheaterController(ITheaterRepository theaterRepository, ILogger<TheaterController> logger)
    {
        _theaterRepository = theaterRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterDto>>> GetTheaters()
    {
        try
        {
            var theaters = await _theaterRepository.GetTheaters();
            var theaterDtos = theaters.ConvertToDto();
            return Ok(theaterDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTheaters");
            return StatusCode(StatusCodes.Status500InternalServerError,  ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TheaterDto>> GetTheater(int id)
    {
        try
        {
            var theater = await _theaterRepository.GetTheater(id);

            if (theater == null)
            {
                return NotFound();
            }

            var theaterDto = theater.ConvertToDto();

            return Ok(theaterDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTheater with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<TheaterDto>> AddTheater(AddTheaterDto addTheaterDto)
    {
        try
        {
            var newTheater = await _theaterRepository.AddTheater(addTheaterDto);
            var newTheaterDto = newTheater.ConvertToDto();

            return CreatedAtAction(nameof(GetTheater), new { id = newTheaterDto.Id }, newTheaterDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddTheater");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<TheaterDto>> UpdateTheater(int id, UpdateTheaterDto updateTheaterDto)
    {
        try
        {
            var updatedTheater = await _theaterRepository.UpdateTheater(id, updateTheaterDto);

            if (updatedTheater == null)
            {
                return NotFound();
            }

            var updatedTheaterDto = updatedTheater.ConvertToDto();

            return Ok(updatedTheaterDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for UpdateTheater with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTheater(int id)
    {
        try
        {
            var theater = await _theaterRepository.DeleteTheater(id);

            if (!theater)
            {
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for DeleteTheater with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}