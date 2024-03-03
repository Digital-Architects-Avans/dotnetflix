using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.TheaterRows;
using dotnetflix.Models.Dtos.TheaterRow;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TheaterRowController : ControllerBase
{
    private readonly ITheaterRowRepository _theaterRowRepository;
    private readonly ILogger<TheaterController> _logger;

    public TheaterRowController(ITheaterRowRepository theaterRowRepository, ILogger<TheaterController> logger)
    {
        _theaterRowRepository = theaterRowRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterRowDto>>> GetTheaterRows()
    {
        try
        {
            var theaterRows = await _theaterRowRepository.GetTheaterRows();
            var theaterRowDtos = theaterRows.ConvertToDto();
            return Ok(theaterRowDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTheaterRows");
            return StatusCode(StatusCodes.Status500InternalServerError,  ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TheaterRowDto>> GetTheaterRow(int id)
    {
        try
        {
            var theaterRow = await _theaterRowRepository.GetTheaterRow(id);

            if (theaterRow == null)
            {
                return NotFound();
            }

            var theaterRowDto = theaterRow.ConvertToDto();

            return Ok(theaterRowDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTheaterRow with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<TheaterRowDto>> AddTheater(AddTheaterRowDto addTheaterRowDto)
    {
        try
        {
            var newTheaterRow = await _theaterRowRepository.AddTheaterRow(addTheaterRowDto);
            var newTheaterRowDto = newTheaterRow.ConvertToDto();

            return CreatedAtAction(nameof(GetTheaterRow), new { id = newTheaterRowDto.Id }, newTheaterRowDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddTheaterRow");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<TheaterRowDto>> UpdateTheater(int id, UpdateTheaterRowDto updateTheaterRowDto)
    {
        try
        {
            var updatedTheaterRow = await _theaterRowRepository.UpdateTheaterRow(id, updateTheaterRowDto);

            if (updatedTheaterRow == null)
            {
                return NotFound();
            }

            var updatedTheaterRowDto = updatedTheaterRow.ConvertToDto();

            return Ok(updatedTheaterRowDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for UpdateTheaterRow with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTheaterRow(int id)
    {
        try
        {
            var theaterRow = await _theaterRowRepository.DeleteTheaterRow(id);

            if (!theaterRow)
            {
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for DeleteTheaterRow with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}