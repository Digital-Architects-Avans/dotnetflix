using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Supplements;
using Microsoft.AspNetCore.Mvc;
using dotnetflix.Models.Dtos.Supplement;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SupplementController : ControllerBase
{
    private readonly ISupplementRepository _supplementRepository;
    private readonly ILogger<SupplementController> _logger;

    public SupplementController(ISupplementRepository supplementRepository, ILogger<SupplementController> logger)
    {
        _supplementRepository = supplementRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SupplementDto>>> GetSupplements()
    {
        try
        {
            var supplements = await _supplementRepository.GetSupplements();
            var supplementDtos = supplements.ConvertToDto();
            return Ok(supplementDtos);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _logger.LogError(e, "Error processing request for GetSupplements");
            return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<SupplementDto>> GetSupplement(int id)
    {
        try
        {
            var supplement = await _supplementRepository.GetSupplement(id);

            if (supplement == null)
                return NotFound();

            var supplementDto = supplement.ConvertToDto();
            return Ok(supplementDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _logger.LogError(e, "Error processing request for GetSupplement with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<SupplementDto>> AddSupplement(AddSupplementDto addSupplementDto)
    {
        try
        {
            var supplement = await _supplementRepository.AddSupplement(addSupplementDto);
            var supplementDto = supplement.ConvertToDto();
            return CreatedAtAction(nameof(GetSupplement), new { id = supplement.Id }, supplementDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _logger.LogError(e, "Error processing request for AddSupplement");
            return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<SupplementDto>> UpdateSupplement(int id, UpdateSupplementDto updateSupplementDto)
    {
        try
        {
            var supplement = await _supplementRepository.UpdateSupplement(id, updateSupplementDto);

            if (supplement == null)
                return NotFound();

            var supplementDto = supplement.ConvertToDto();
            return Ok(supplementDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _logger.LogError(e, "Error processing request for UpdateSupplement with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteSupplement(int id)
    {
        try
        {
            var result = await _supplementRepository.DeleteSupplement(id);

            if (result == false)
                return NotFound();

            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _logger.LogError(e, "Error processing request for DeleteSupplement with ID: {Id}", id);
            return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
        }
    }
}