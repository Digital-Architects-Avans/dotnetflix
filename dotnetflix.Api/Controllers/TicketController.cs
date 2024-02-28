using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Contracts;
using dotnetflix.Api.Repositories.Movies;
using dotnetflix.Api.Repositories.Shows;
using dotnetflix.Api.Repositories.Theaters;
using dotnetflix.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
	private readonly ITicketRepository _ticketRepository;
	private readonly IShowRepository _showRepository;
	private readonly IMovieRepository _movieRepository;
	private readonly ITheaterRepository _theaterRepository;

	public TicketController
		(
			ITicketRepository ticketRepository, 
			IShowRepository showRepository, 
			IMovieRepository movieRepository,
			ITheaterRepository theaterRepository
		)
	{
		_ticketRepository	= ticketRepository;
		_showRepository		= showRepository;
		_movieRepository	= movieRepository;
		_theaterRepository	= theaterRepository;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<TicketDto>>> GetTickets()
	{
		try
		{
			var tickets	= await _ticketRepository.GetTickets();
			if (tickets == null)
			{
				throw new Exception("No tickets found..");
			}
			
			var movies = await _movieRepository.GetMovies();
			if (movies == null)
			{
				throw new Exception("No movies found..");
			}

			var shows = await _showRepository.GetShows();
			if (shows == null)
			{
				throw new Exception("No shows found..");
			}

			var theaters = await _theaterRepository.GetTheaters();
			if (theaters == null)
			{
				throw new Exception("No theaters found..");
			}

			var seats = await _ticketRepository.GetSeats();
			if (seats == null)
			{
				throw new Exception("No seats found..");
			}

			var ticketDtos = tickets.ConvertToDto(movies, shows, theaters, seats);
			return Ok(ticketDtos);

		}
		catch (Exception)
		{
			return StatusCode(
				StatusCodes.Status500InternalServerError,
				"Error retrieving data from the database.."
			);
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
			return StatusCode(
				StatusCodes.Status500InternalServerError,
				ex.Message
			);
		}
	}
}
