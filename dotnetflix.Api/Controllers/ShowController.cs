using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Shows;
using dotnetflix.Models.Dtos.Show;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShowController : ControllerBase
{
    private readonly IShowRepository _showRepository;
    private readonly ILogger<ShowController> _logger;
    
    public ShowController(IShowRepository showRepository, ILogger<ShowController> logger)
    {
        _showRepository = showRepository;
        _logger = logger;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ShowDto>>> GetShows()
    {
        try
        {
            var shows = await _showRepository.GetShows();
            var showDtos = shows.ConvertToDto();
            return Ok(showDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetShows");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
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
            _logger.LogError(ex, "Error processing request for GetShow with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ShowDto>> AddShow(AddShowDto addShowDto)
    {
        try
        {
            var newShow = await _showRepository.AddShow(addShowDto);

            var newShowDto = newShow.ConvertToDto();
            
            return CreatedAtAction(nameof(GetShow), new { id = newShowDto.Id }, newShowDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddShow");
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
                return NoContent();
            }

            var updatedShowDto = updatedShow.ConvertToDto();

            return Ok(updatedShowDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for UpdateShow with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteShow(int id)
    {
        try
        {
            var show = await _showRepository.DeleteShow(id);

            if (!show)
            {
                return NotFound();
            }
            
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for DeleteShow with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}