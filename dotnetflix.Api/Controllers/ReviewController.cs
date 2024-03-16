using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Repositories.Reviews;
using Microsoft.AspNetCore.Mvc;
using dotnetflix.Api.Extensions;
using dotnetflix.Models.Dtos.Review;

namespace dotnetflix.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ReviewController : ControllerBase
{
    private readonly IReviewRepository _reviewRepository;

    public ReviewController(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
    {
        try
        {
            var reviews = await _reviewRepository.GetReviews();
            var reviewDtos = reviews.ConvertToDto();
            return Ok(reviewDtos);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ReviewDto>> GetReview(int id)
    {
        try
        {
            var review = await _reviewRepository.GetReview(id);

            if (review == null)
            {
                return NotFound();
            }

            var reviewDto = review.ConvertToDto();

            return Ok(reviewDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<Review>> AddReview([FromBody] AddReviewDto addReviewDto)
    {
        try
        {
            var newReview = await _reviewRepository.AddReview(addReviewDto);
            var newReviewDto = newReview.ConvertToDto();
            return CreatedAtAction(nameof(GetReview), new { id = newReview.Id }, newReviewDto);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}