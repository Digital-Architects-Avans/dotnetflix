using System.Net.Http.Json;
using dotnetflix.Api.Services.Contracts;
using dotnetflix.Models.Dtos.Review;

namespace dotnetflix.Api.Services;

public class MockTrustpilotService : ITrustpilotService
{
   private readonly HttpClient _httpClient;
   
   public MockTrustpilotService(HttpClient httpClient)
   {
       _httpClient = httpClient;
   }

   public async Task<IEnumerable<ReviewDto>> GetReviews()
   {
       try
       {
           var response = await _httpClient.GetAsync("api/Review");
           if (response.IsSuccessStatusCode)
           {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
               {
                   return default(IEnumerable<ReviewDto>);
               }

               var reviews = await response.Content.ReadFromJsonAsync<IEnumerable<ReviewDto>>();
               return reviews.OrderByDescending(r => r.Id);

           }
           else
           {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception(message);
           }
       }
       catch (Exception e)
       {
           Console.WriteLine($"An error occurred: {e.Message}");
           throw;
       }
   }

   public async Task<AddReviewDto> AddReview(AddReviewDto newReview)
   {
       var addReviewDto = new AddReviewDto
       {
           Name = newReview.Name,
           Stars = newReview.Stars,
           ReviewText = newReview.ReviewText
       };

       try
       {
           var response = await _httpClient.PostAsJsonAsync("api/Review", addReviewDto);
           response.EnsureSuccessStatusCode();

           if (response.IsSuccessStatusCode)
           {
               return await Task.FromResult(addReviewDto);
           }
       }
       catch (HttpRequestException ex)
       {
           Console.WriteLine($"An error occurred: {ex.Message}");
           throw;
       }

       return null;
   }
   
   public async Task<double> GetTrustScore()
   {
       var reviews = await GetReviews();
       if (reviews != null && reviews.Any())
       {
           return reviews.Average(r => r.Stars);
       }
       return 0;
   }
   
}