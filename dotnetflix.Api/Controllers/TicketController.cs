using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Contracts;
using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.Ticket;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
	private readonly ITicketRepository _ticketRepository;
	private readonly ILogger<TicketController> _logger;

	public TicketController(ITicketRepository ticketRepository, ILogger<TicketController> logger)
	{
		_ticketRepository = ticketRepository;
		_logger = logger;
	}
	
	[HttpGet]
	public async Task<ActionResult<IEnumerable<TicketDto>>> GetTickets()
	{
		try
		{
			var tickets = await _ticketRepository.GetTickets();
			var ticketDtos = tickets.ConvertToDto();
			return Ok(ticketDtos);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetTickets");
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpGet("Show/{showId:int}")]
	public async Task<ActionResult<IEnumerable<TicketDto>>> GetTicketsForShow(int showId)
	{
		try
		{
			var tickets = await _ticketRepository.GetTicketsForShow(showId);
			var ticketDtos = tickets.ConvertToDto();
			return Ok(ticketDtos);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetTicketsForShow");
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult<IEnumerable<TicketDto>>> GetTicket(int id)
	{
		try
		{
			var ticket = await _ticketRepository.GetTicket(id);
			
			if (ticket == null)
			{
				return NotFound();
			}

			var ticketDto = ticket.ConvertToDto();
			return Ok(ticketDto);

		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetTicket with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpPost]
	public async Task<ActionResult<TicketDto>> AddTicket([FromBody] AddTicketDto addTicketDto)
	{
		try
		{
			var newTicket = await _ticketRepository.AddTicket(addTicketDto);
			var newTicketDto = newTicket.ConvertToDto();

			return CreatedAtAction(nameof(GetTicket), new { id = newTicketDto.Id }, newTicketDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for AddTicket");
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpPut("{id:int}")]
	public async Task<ActionResult<TicketDto>> UpdateTicket(int id, UpdateTicketDto updateTicketDto)
	{
		try
		{
			var updatedTicket = await _ticketRepository.UpdateTicket(id, updateTicketDto);

			if (updatedTicket == null)
			{
				return NoContent();
			}

			var updatedTicketDto = updatedTicket.ConvertToDto();

			return Ok(updatedTicketDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for UpdateTicket with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteTicket(int id)
	{
		try
		{
			bool deleted = await _ticketRepository.DeleteTicket(id);

			if (!deleted)
			{
				return NotFound();
			}

			return NoContent();
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for DeleteTicket with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
}
