using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Contracts;
using dotnetflix.Api.Repositories.TicketTypes;
using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.Ticket;
using dotnetflix.Models.Dtos.TicketType;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketTypeController : ControllerBase
{
	private readonly ITicketTypeRepository _ticketTypeRepository;
	private readonly ILogger<TicketController> _logger;

	public TicketTypeController(ITicketTypeRepository ticketTypeRepository, ILogger<TicketController> logger)
	{
		_ticketTypeRepository = ticketTypeRepository;
		_logger = logger;
	}
	
	[HttpGet]
	public async Task<ActionResult<IEnumerable<TicketTypeDto>>> GetTicketTypes()
	{
		try
		{
			var ticketTypes = await _ticketTypeRepository.GetTicketTypes();
			var ticketTypeDtos = ticketTypes.ConvertToDto();
			return Ok(ticketTypeDtos);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetTicketTypes");
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult<IEnumerable<TicketTypeDto>>> GetTicketType(int id)
	{
		try
		{
			var ticketType = await _ticketTypeRepository.GetTicketType(id);
			
			if (ticketType == null)
			{
				return NotFound();
			}

			var ticketTypeDto = ticketType.ConvertToDto();
			return Ok(ticketTypeDto);

		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetTicketType with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpPost]
	public async Task<ActionResult<TicketTypeDto>> AddTicketType([FromBody] AddTicketTypeDto addTicketTypeDto)
	{
		try
		{
			var newTicketType = await _ticketTypeRepository.AddTicketType(addTicketTypeDto);
			var newTicketTypeDto = newTicketType.ConvertToDto();

			return CreatedAtAction(nameof(GetTicketType), new { id = newTicketType.Id }, newTicketTypeDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for AddTicket");
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpPut("{id:int}")]
	public async Task<ActionResult<TicketDto>> UpdateTicketType(int id, UpdateTicketTypeDto updateTicketTypeDto)
	{
		try
		{
			var updatedTicketType = await _ticketTypeRepository.UpdateTicketType(id, updateTicketTypeDto);

			if (updatedTicketType == null)
			{
				return NoContent();
			}

			var updatedTicketTypeDto = updatedTicketType.ConvertToDto();

			return Ok(updatedTicketTypeDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for UpdateTicketType with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}

	[HttpDelete("{id:int}")]
	public async Task<IActionResult> DeleteTicketType(int id)
	{
		try
		{
			bool deleted = await _ticketTypeRepository.DeleteTicketType(id);

			if (!deleted)
			{
				return NotFound();
			}

			return NoContent();
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for DeleteTicketType with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
}
