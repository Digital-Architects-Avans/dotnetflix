using dotnetflix.Api.Extensions;
using dotnetflix.Api.Repositories.Orders;
using dotnetflix.Models.Dtos.Order;
using Microsoft.AspNetCore.Mvc;

namespace dotnetflix.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
	private readonly IOrderRepository _orderRepository;
	private readonly ILogger<OrderController> _logger;
	
	public OrderController(IOrderRepository orderRepository, ILogger<OrderController> logger)
	{
		_orderRepository = orderRepository;
		_logger = logger;
	}


	[HttpGet]
	public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders()
	{
		try
		{
			var orders = await _orderRepository.GetOrders();
			var orderDtos = orders.ConvertToDto();
			return Ok(orderDtos);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetOrders");
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrder(int id)
	{
		try
		{
			var order = await _orderRepository.GetOrder(id);
			
			if (order == null)
			{
				return NotFound();
			}

			var orderDto = order.ConvertToDto();
			return Ok(orderDto);

		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetOrder with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpGet("uuid/{uuid}")]
	public async Task<ActionResult<OrderDto>> GetOrderByUUID(string uuid)
	{
		try
		{
			var order = await _orderRepository.GetOrderByUUID(uuid);

			if (order == null)
			{
				return NotFound();
			}

			var orderDto = order.ConvertToDto();
			return Ok(orderDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for GetOrderByUUID with UUID: {UUID}", uuid);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpPost]
	public async Task<ActionResult<OrderDto>> AddOrder([FromBody] AddOrderDto addOrderDto)
	{
		try
		{
			var newOrder = await _orderRepository.AddOrder(addOrderDto);
			var newOrderDto = newOrder.ConvertToDto();

			return CreatedAtAction(nameof(GetOrder), new { id = newOrderDto.Id }, newOrderDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for AddOrder");

			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
	
	[HttpPut("{id:int}")]
	public async Task<ActionResult<OrderDto>> UpdateOrder(int id, UpdateOrderDto updateOrderDto)
	{
		try
		{
			var updatedOrder = await _orderRepository.UpdateOrder(id, updateOrderDto);

			if (updatedOrder == null)
			{
				return NoContent();
			}

			var updatedOrderDto = updatedOrder.ConvertToDto();

			return Ok(updatedOrderDto);
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for UpdateOrder with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}

	[HttpDelete("{id:int}")]
	public async Task<IActionResult> DeleteOrder(int id)
	{
		try
		{
			var order = await _orderRepository.DeleteOrder(id);

			if (!order)
			{
				return NotFound();
			}

			return NoContent();
		}
		catch (Exception ex)
		{
			_logger.LogError(ex, "Error processing request for DeleteOrder with ID: {Id}", id);
			return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		}
	}
}
