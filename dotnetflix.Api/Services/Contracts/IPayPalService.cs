namespace dotnetflix.Api.Services.Contracts;

public interface IPayPalService
{
     Task<bool> VerifyPaymentSuccess(string paymentId);
}