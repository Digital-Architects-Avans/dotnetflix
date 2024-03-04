using dotnetflix.Api.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPayPalService _payPalService;

    public PaymentController(IPayPalService payPalService)
    {
        _payPalService = payPalService;
    }

    [HttpGet("verify/{paymentId}")]
    public async Task<IActionResult> VerifyPayment(string paymentId)
    {
        var isSuccess = await _payPalService.VerifyPaymentSuccess(paymentId);
        if (isSuccess)
        {
            return Ok(new { Message = "Payment verified successfully." });
        }
        else
        {
            return BadRequest(new { Message = "Failed to verify payment." });
        }
    }
}