using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Repositories.Shows;

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
    public async Task<ActionResult<IEnumerable<Theater>>> GetTheaters()
    {
        try
        {
            var theaters = await this.theaterRepository.GetTheaters();
            return Ok(theaters);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Theater>> GetTheater(int id)
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
    public async Task<ActionResult<Theater>> AddTheater(Theater theater)
    {
        try
        {
            var newTheater = await this.theaterRepository.AddTheater(theater);
            return Ok(newTheater);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPut]
    public async Task<ActionResult<Theater>> UpdateTheater(Theater theater)
    {
        try
        {
            var updatedTheater = await this.theaterRepository.UpdateTheater(theater);
            return Ok(updatedTheater);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult<Theater>> DeleteTheater(int id)
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