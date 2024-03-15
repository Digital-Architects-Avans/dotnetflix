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
                    Name = "Test Review 1",
                    Text = "This is a test review.",
                    Stars = 5
                },
                new TrustpilotReview
                {
                    Name = "Test Review 2",
                    Text = "This is another test review.",
                    Stars = 4
                }
            }
        });
    }
}