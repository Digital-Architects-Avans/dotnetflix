using dotnetflix.Api.Entities;
using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Movies;
using dotnetflix.Api.Repositories.Seats;
using Microsoft.AspNetCore.Mvc;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Seat;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeatController : ControllerBase
{
    private readonly ISeatRepository _seatRepository;
    private readonly ILogger<MovieController> _logger;


    public SeatController(ISeatRepository seatRepository, ILogger<MovieController> logger)
    {
        _seatRepository = seatRepository;
        _logger = logger;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Seat>>> GetSeats()
    {
        try
        {
            var seats = await _seatRepository.GetSeats();
            var seatDtos = seats.ConvertToDto();
            return Ok(seatDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetSeats");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<SeatDto?>> GetSeat(int id)
    {
        try
        {
            var seat = await _seatRepository.GetSeat(id);

            if (seat == null)
            {
                return NotFound();
            }

            var seatDto = seat.ConvertToDto();

            return Ok(seatDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetSeat with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    
    [HttpGet("Theater/{theaterId:int}")]
    public async Task<ActionResult<IEnumerable<Seat>>> GetSeatsForTheater(int theaterId)
    {
        try
        {
            var seats = await _seatRepository.GetSeatsForTheater(theaterId);
            var seatsDto = seats.ConvertToDto();
            return Ok(seatsDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetSeat with ID: {theaterId}", theaterId);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<SeatDto>> AddSeat([FromBody] AddSeatDto addSeatDto)
    {
        try
        {
            var newSeat = await _seatRepository.AddSeat(addSeatDto);

            var newSeatdto = newSeat.ConvertToDto();

            return CreatedAtAction(nameof(GetSeat), new { id = newSeatdto.Id }, newSeatdto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddSeat");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<SeatDto>> UpdateSeat(int id, UpdateSeatDto updateSeatDto)
    {
        try
        {
            var updatedSeat = await _seatRepository.UpdateSeat(id, updateSeatDto);

            if (updatedSeat == null)
            {
                return NoContent();
            }

            var updatedSeatDto = updatedSeat.ConvertToDto();

            return Ok(updatedSeatDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for UpdateSeat with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteSeat(int id)
    {
        try
        {
            var seat = await _seatRepository.DeleteSeat(id);

            if (!seat)
            {
                return NotFound();
            }

            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for DeleteSeat with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}