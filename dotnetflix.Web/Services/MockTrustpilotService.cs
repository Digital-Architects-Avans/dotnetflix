using dotnetflix.Api.Services.Contracts;

namespace dotnetflix.Api.Services;

public class MockTrustpilotService : ITrustpilotService
{
    public Task<TrustpilotReviews> GetReviewsAsync()
    {
        return Task.FromResult(new TrustpilotReviews
        {
            Reviews = new[]
            {
                new TrustpilotReview
                {
                    Name = "Karl",
                    ReviewText = "Toffe film wel!",
                    Stars = 5
                },
                new TrustpilotReview
                {
                    Name = "Karen",
                    ReviewText = "De popcorn plakt aan je vingers",
                    Stars = 2
                }
            }
        });
    }
}