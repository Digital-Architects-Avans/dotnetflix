using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.TicketSupplements;
using dotnetflix.Models.Dtos.TicketSupplements;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketSupplementController : ControllerBase
{
    private readonly ITicketSupplementRepository _ticketSupplementRepository;
    private readonly ILogger<TicketSupplementController> _logger;


    public TicketSupplementController(ITicketSupplementRepository ticketSupplementRepository, ILogger<TicketSupplementController> logger)
    {
        _ticketSupplementRepository = ticketSupplementRepository;
        _logger = logger;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TicketSupplementDto>>> GetTicketSupplements()
    {
        try
        {
            var ticketSupplements = await _ticketSupplementRepository.GetTicketSupplements();
            var ticketSupplementsDtos = ticketSupplements.ConvertToDto();
            return Ok(ticketSupplementsDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTicketSupplements");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TicketSupplementDto>> GetTicketSupplement(int id)
    {
        try
        {
            var ticketSupplement = await _ticketSupplementRepository.GetTicketSupplement(id);

            if (ticketSupplement == null)
            {
                return NotFound();
            }

            var ticketSupplementDto = ticketSupplement.ConvertToDto();

            return Ok(ticketSupplementDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTicketSupplement with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    
    [HttpGet("Ticket/{id:int}")]
    public async Task<ActionResult<TicketSupplementDto>> GetTicketSupplementsForTicket(int id)
    {
        try
        {
            var ticketSupplements = await _ticketSupplementRepository.GetTicketSupplementsForTicket(id);
            var ticketSupplementDto = ticketSupplements.ConvertToDto();

            return Ok(ticketSupplementDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetTicketSupplementsForTicket with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<TicketSupplementDto>> AddTicketSupplement([FromBody] AddTicketSupplementDto addTicketSupplementDto)
    {
        try
        {
            var newTicketSupplement = await _ticketSupplementRepository.AddTicketSupplement(addTicketSupplementDto);

            var newTicketSupplementDto = newTicketSupplement.ConvertToDto();

            return CreatedAtAction(nameof(GetTicketSupplement), new { id = newTicketSupplementDto.Id }, newTicketSupplementDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddTicketSupplement");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<TicketSupplementDto>> UpdateTicketSupplement(int id, UpdateTicketSupplementDto updateTicketSupplementDto)
    {
        try
        {
            var updatedTicketSupplement = await _ticketSupplementRepository.UpdateTicketSupplement(id, updateTicketSupplementDto);

            if (updatedTicketSupplement == null)
            {
                return NoContent();
            }

            var updatedTicketSupplementDto = updatedTicketSupplement.ConvertToDto();

            return Ok(updatedTicketSupplementDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for UpdateTicketSupplement with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTicketSupplement(int id)
    {
        try
        {
            var ticketSupplement = await _ticketSupplementRepository.DeleteTicketSupplement(id);

            if (!ticketSupplement)
            {
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for DeleteTicketSupplement with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}