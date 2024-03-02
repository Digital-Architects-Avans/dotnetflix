using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Order;

namespace dotnetflix.Api.Repositories.Orders;

/*
 * The IOrderRepository interface is used to define the methods that will be used to interact with the Order entity in the database.
 */

public interface IOrderRepository
{
	Task<IEnumerable<Order>> GetOrders();
	Task<Order?> GetOrder(int id);
	Task<Order> AddOrder(AddOrderDto addOrderDto);
	Task<Order?> UpdateOrder(int id, UpdateOrderDto updateOrderDto);
	Task<bool> DeleteOrder(int id);
}
