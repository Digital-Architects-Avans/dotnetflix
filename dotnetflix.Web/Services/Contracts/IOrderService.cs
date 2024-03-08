using dotnetflix.Models.Dtos.Order;
using dotnetflix.Models.Dtos.OrderRequestDtos;

namespace dotnetflix.Web.Services.Contracts;

public interface IOrderService
{
	Task<OrderDto?> GetOrderByUuid(string uuid);
	Task<IEnumerable<OrderDto>> GetItems();
	Task<OrderDto> GetOrder(int id);
	Task<bool> VerifyPaymentSuccess(string paymentId);
	Task<OrderDto> CreateOrder(OrderRequestDto orderRequestDto);
}
