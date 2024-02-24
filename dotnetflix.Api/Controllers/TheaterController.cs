using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Theaters;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]

public class TheaterController : ControllerBase
{
    private readonly ITheaterRepository theaterRepository;
    public TheaterController(ITheaterRepository theaterRepository)
    {
        this.theaterRepository = theaterRepository;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TheaterDto>>> GetTheaters()
    {
        try
        {
            var theaters = await this.theaterRepository.GetTheaters();
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
            var theater = await this.theaterRepository.GetTheater(id);
            return Ok(theater);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPost]
    public async Task<ActionResult<TheaterDto>> AddTheater(TheaterDto theaterDto)
    {
        try
        {
            var theater = theaterDto.ConvertToEntity();
            var newTheater = await this.theaterRepository.AddTheater(theater);
            return Ok(newTheater.ConvertToDto());
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<TheaterDto>> UpdateTheater(TheaterDto theaterDto)
    {
        try
        {
            var theater = theaterDto.ConvertToEntity();
            var updatedTheater = await this.theaterRepository.UpdateTheater(theater);
            return Ok(updatedTheater.ConvertToDto());
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
            var theater = await this.theaterRepository.DeleteTheater(id);
            return Ok(theater);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    

}

