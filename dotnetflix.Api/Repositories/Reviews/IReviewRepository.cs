using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Review;

namespace dotnetflix.Api.Repositories.Reviews;

public interface IReviewRepository
{
    Task<IEnumerable<Review>> GetReviews();
    // Task<ReviewDto> GetReview(int id);
    Task<Review> AddReview(AddReviewDto addReviewDto);
    // Task<ReviewDto> UpdateReview(int id, ReviewDto reviewDto);
    // Task<bool> DeleteReview(int id);
}