using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Subscribers;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Subscriber;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]

public class SubscriberController : ControllerBase
{
    private readonly ISubscribersRepository _subscriberRepository;
    private readonly ILogger<SubscriberController> _logger;

    public SubscriberController(ISubscribersRepository subscriberRepository, ILogger<SubscriberController> logger)
    {
        _subscriberRepository = subscriberRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SubscriberDto>>> GetSubscribers()
    {
        try
        {
            var subscribers = await _subscriberRepository.GetSubscribers();
            var subscriberDtos = subscribers.ConvertToDto();
            return Ok(subscriberDtos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for GetSubscribers");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<SubscriberDto>> AddSubscriber([FromBody] AddSubscriberDto addSubscriberDto)
    {
        try
        {
            var newSubscriber = await _subscriberRepository.AddSubscriber(addSubscriberDto);

            var newSubscriberDto = newSubscriber.ConvertToDto();

            return CreatedAtAction(nameof(GetSubscribers), new { id = newSubscriberDto.Id }, newSubscriberDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing request for AddSubscriber");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}

