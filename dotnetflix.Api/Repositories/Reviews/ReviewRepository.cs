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

    public Task<Review> AddReview(AddReviewDto addReviewDto)
    {
        throw new NotImplementedException();
    }
    
}