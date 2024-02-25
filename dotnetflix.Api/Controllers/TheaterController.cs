using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Theaters;
using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.Theater;

namespace dotnetflix.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]

public class TheaterController : ControllerBase
{
    private readonly ITheaterRepository _theaterRepository;

    public TheaterController(ITheaterRepository theaterRepository)
    {
        _theaterRepository = theaterRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterDto>>> GetTheaters()
    {
        try
        {
            var theaters = await _theaterRepository.GetTheaters();
            if (theaters == null)
            {
                return NotFound();
            }
            else
            {
                var theaterDtos = theaters.ConvertToDto();
                return Ok(theaterDtos);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TheaterDto>> GetTheater(int id)
    {
        try
        {
            var theater = await _theaterRepository.GetTheater(id);

            if (theater == null)
            {
                return NotFound();
            }
            else
            {
                var theaterDto = theater.ConvertToDto();
                
                return Ok(theaterDto);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<TheaterDto>> AddTheater(AddTheaterDto addTheaterDto)
    {
        try
        {
            var newTheater = await _theaterRepository.AddTheater(addTheaterDto);
            
            if (newTheater == null)
            {
                return NoContent();
            }
            
            var newTheaterDto = newTheater.ConvertToDto();
            
            return Ok(newTheaterDto);
        }
        catch (Exception ex)
        {
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<TheaterDto>> DeleteTheater(int id)
    {
        try
        {
            var theater = await _theaterRepository.DeleteTheater(id);

            if (theater == null)
            {
                return NotFound();
            }
            var theaterDto = theater.ConvertToDto();
            
            return Ok(theaterDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}

