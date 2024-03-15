namespace dotnetflix.Api.Services.Contracts;

public interface ITrustpilotService
{
    Task<TrustpilotReviews> GetReviewsAsync();
}

public class TrustpilotReviews
{
    public TrustpilotReview[] Reviews { get; set; }
}

public class TrustpilotReview
{
    public string Name { get; set; }
    public string ReviewText { get; set; }
    public int Stars { get; set; }
}