using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using dotnetflix.Api.Services.Contracts;
using Microsoft.Extensions.Options;

namespace dotnetflix.Api.Services;

public class PayPalService : IPayPalService
{
    private readonly HttpClient _httpClient;
    private readonly PayPalSettings _payPalSettings;

    public PayPalService(IHttpClientFactory httpClientFactory, IOptions<PayPalSettings> payPalSettings)
    {
        _httpClient = httpClientFactory.CreateClient("PayPalSandBoxHttpClient");
        _payPalSettings = payPalSettings.Value;
    }

    public async Task<string?> GetAccessTokenAsync()
    {
        // Todo: Move the client id and secret to the appsettings.json file and use IOptions to get the values
        var  clientId = _payPalSettings.ClientId;
        var  clientSecret = _payPalSettings.ClientSecret;

        var basicAuth = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{clientId}:{clientSecret}"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", basicAuth);

        var response = await _httpClient.PostAsync(
            "v1/oauth2/token",
            new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded"));

        if (response.IsSuccessStatusCode)
        {
            var payload = await JsonSerializer.DeserializeAsync<PayPalTokenResponse>(await response.Content.ReadAsStreamAsync());
            Console.WriteLine($"Received token: {payload?.AccessToken}");
            return payload?.AccessToken;
        }
        else
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Failed to retrieve token: {errorContent}");
            throw new HttpRequestException($"Failed to retrieve token: {errorContent}");
        }
    }

    public async Task<bool> VerifyPaymentSuccess(string orderId)
    {
        string? accessToken = await GetAccessTokenAsync();
        
        if (string.IsNullOrEmpty(accessToken))
        {
            return false;
        }
        
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        // https://developer.paypal.com/docs/api/payments/v2/#captures_get
        var response = await _httpClient.GetAsync($"v2/checkout/orders/{orderId}");
        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        Console.WriteLine(response.Content.ReadAsStreamAsync());

        var paymentDetails = await JsonSerializer.DeserializeAsync<PaymentDetails>(await response.Content.ReadAsStreamAsync());

        // Check the status of the paymentDetails to determine success
        return paymentDetails != null && paymentDetails.Status == "COMPLETED";
    }

    public class PaymentDetails
    {
        [JsonPropertyName("id")] public string? Id { get; set; }

        [JsonPropertyName("status")] public string? Status { get; set; }
    }

    public class PayPalTokenResponse
    {
        [JsonPropertyName("access_token")] 
        public string? AccessToken { get; set; }
    }
}

public class PayPalSettings
{
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
}