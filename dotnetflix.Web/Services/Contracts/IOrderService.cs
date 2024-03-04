using dotnetflix.Models.Dtos.Order;

namespace dotnetflix.Web.Services.Contracts;

public interface IOrderService
{
	Task<IEnumerable<OrderDto>> GetItems();
	Task<OrderDto> GetOrder(int id);
}
