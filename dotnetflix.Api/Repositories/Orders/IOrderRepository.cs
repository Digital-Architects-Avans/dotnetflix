using dotnetflix.Api.Data.Entities;

namespace dotnetflix.Api.Repositories.Orders;

/*
 * The IOrderRepository interface is used to define the methods that will be used to interact with the Order entity in the database.
 */

public interface IOrderRepository
{
	Task<IEnumerable<Order>> GetOrders();
	Task<Order> GetOrder(int id);
	Task<Order> AddOrder(Show show);
	Task<Order> UpdateOrder(int id);
	Task<Order> DeleteOrder(int id);
	Task<Order> CalculatePrice(Ticket ticket);
	Task<Order> GetShowAvailability(Show show);
}
