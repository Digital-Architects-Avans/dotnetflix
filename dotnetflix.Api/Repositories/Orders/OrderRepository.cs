using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Order;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Orders;

/*
 * OrderRepository
 * 
 * This class is responsible for handling the database operations for the Order entity.
 * 
 * It implements the IOrderRepository interface.
 */

public class OrderRepository
{
	private readonly DotNetFlixDbContext _dotNetFlixDbContext;

	// CREATE DATABASE REFERENCE
	public OrderRepository(DotNetFlixDbContext dotNetFlixDbContext)
	{
		_dotNetFlixDbContext = dotNetFlixDbContext;
	}

	// GET LIST OF ORDERS
	public async Task<IEnumerable<Order>> GetOrders()
	{
		var orders = await _dotNetFlixDbContext.Orders.ToListAsync();
		return orders;
	}

	// GET SINGLE ORDER
	public Task<Order> GetOrder(int id)
	{
		throw new NotImplementedException();
	}

	public async Task<Order> AddOrder(AddOrderDto addOrderDto)
	{
		var order = new Order
		{
			// TO-DO: Add properties
		};

		var result = await _dotNetFlixDbContext.Orders.AddAsync(order);
		await _dotNetFlixDbContext.SaveChangesAsync();
		return result.Entity;
	}
}
