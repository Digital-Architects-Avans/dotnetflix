using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Review;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Reviews;

public class ReviewRepository : IReviewRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;
    
    public ReviewRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    public async Task<IEnumerable<Review>> GetReviews()
    {
        var reviews = await _dotNetFlixDbContext.Reviews.ToListAsync();
        return reviews;
    }
    
    public async Task<Review?> GetReview(int id)
    {
        var review = await _dotNetFlixDbContext.Reviews.SingleOrDefaultAsync(r => r.Id == id);
        return review;
    }

    public async Task<Review> AddReview(AddReviewDto addReviewDto)
    {
        var review = new Review
        {
            Name = addReviewDto.Name,
            Stars = addReviewDto.Stars,
            ReviewText = addReviewDto.ReviewText
        };
        var result = _dotNetFlixDbContext.Reviews.AddAsync(review);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Result.Entity;
    }
    
}