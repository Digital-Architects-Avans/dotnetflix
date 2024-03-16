using dotnetflix.Models.Dtos.Review;

namespace dotnetflix.Api.Services.Contracts;

public interface ITrustpilotService
{
    Task<IEnumerable<ReviewDto>> GetReviews();
    Task<AddReviewDto> AddReview(AddReviewDto addReviewDto);
}



