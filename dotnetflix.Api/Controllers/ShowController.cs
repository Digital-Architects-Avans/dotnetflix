using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Shows;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[Route("api/[controller]")]
[ApiController]

public class ShowController : ControllerBase
{
    private readonly IShowRepository showRepository;
    public ShowController(IShowRepository showRepository)
    {
        this.showRepository = showRepository;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ShowDto>>> GetShows()
    {
        try
        {
            var shows = await this.showRepository.GetShows();
            return Ok(shows);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<ShowDto>> GetShow(int id)
    {
        try
        {
            var show = await this.showRepository.GetShow(id);
            return Ok(show);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPost]
    public async Task<ActionResult<ShowDto>> AddShow(ShowDto showDto)
    {
        try
        {
            var show = showDto.ConvertToEntity();
            var newShow = await this.showRepository.AddShow(show);
            return Ok(newShow);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpPut]
    public async Task<ActionResult<ShowDto>> UpdateShow(Show show)
    {
        try
        {
            var updatedShow = await this.showRepository.UpdateShow(show);
            return Ok(updatedShow);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult<ShowDto>> DeleteShow(int id)
    {
        try
        {
            var show = await this.showRepository.DeleteShow(id);
            return Ok(show);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}