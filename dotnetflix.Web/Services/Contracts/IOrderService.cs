using dotnetflix.Models.Dtos.Order;
using dotnetflix.Models.Dtos.OrderRequestDtos;

namespace dotnetflix.Web.Services.Contracts;

public interface IOrderService
{
	Task<bool> VerifyPaymentSuccess(string paymentId);
	Task<OrderDto> CreateOrder(OrderRequestDto orderRequestDto);
}
