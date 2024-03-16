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
           var response = await _httpClient.GetAsync("api/Review/GetReviews");
           if (response.IsSuccessStatusCode)
           {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
               {
                   return default(IEnumerable<ReviewDto>);
               }

               return await response.Content.ReadFromJsonAsync<IEnumerable<ReviewDto>>();
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

   public Task<AddReviewDto> AddReview(AddReviewDto newReview)
   {
       var addReviewDto = new AddReviewDto
       {
           Name = newReview.Name,
           Stars = newReview.Stars,
           ReviewText = newReview.ReviewText
       };
       
       var response = _httpClient.PostAsJsonAsync("api/Review", addReviewDto);
       
       if (response.Result.IsSuccessStatusCode)
       {
           return Task.FromResult(addReviewDto);
       }
       else
       {
           var message = response.Result.Content.ReadAsStringAsync();
           throw new Exception(message.Result);
       }
   }
}