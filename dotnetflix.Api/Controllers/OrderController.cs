using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.Order;
using dotnetflix.Web.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

public class OrderController
{
	private readonly IOrderService _orderService;

	public OrderController(IOrderService orderService, ITicketService ticketService)
	{
		_orderService = orderService;
	}

	[HttpGet]
	public async Task<IEnumerable<OrderDto>> GetOrders()
	{
		return await _orderService.GetItems();
	}
}
