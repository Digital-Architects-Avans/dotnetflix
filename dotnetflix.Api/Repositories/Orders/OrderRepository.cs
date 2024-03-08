using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Order;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Orders;

public class OrderRepository : IOrderRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    public OrderRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }
    
    public async Task<Order?> GetOrderByUuid(string uuid)
    {
        return await _dotNetFlixDbContext.Orders
            .Include(o => o.Tickets)
            .FirstOrDefaultAsync(o => o.Uuid == uuid);
    }

    public async Task<IEnumerable<Order>> GetOrders()
    {
        var orders = await _dotNetFlixDbContext.Orders
            .Include(o => o.Tickets)
            .ToListAsync();
        return orders;
    }

    public async Task<Order?> GetOrder(int id)
    {
        // Using eager loading to simplify the query
        return await _dotNetFlixDbContext.Orders
            .Include(o => o.Tickets)
            .AsNoTracking() // Added for read-only operation
            .SingleOrDefaultAsync(o => o.Id == id);
    }

    public async Task<Order> AddOrder(AddOrderDto addOrderDto)
    {
        // If the ticket is already assigned to an order, we should not allow it to be assigned to another order
        var tickets = await _dotNetFlixDbContext.Tickets
            .Where(t => addOrderDto.TicketIds.Contains(t.Id) && t.OrderId == null)
            .ToListAsync();

        if (tickets.Count != addOrderDto.TicketIds.Count)
        {
            throw new KeyNotFoundException("One or more tickets were not found or are already assigned.");
        }

        // Calculate the total price as the sum of all ticket prices
        var totalPrice = tickets.Sum(t => t.TicketPrice);

        var order = new Order
        {
            Tickets = tickets,
            TotalPrice = totalPrice, 
            CustomerName = addOrderDto.CustomerName,
            CustomerEmail = addOrderDto.CustomerEmail,
            Uuid = addOrderDto.UUID
        };

        tickets.ForEach(t => t.OrderId = order.Id); // Assign the OrderId to each ticket

        _dotNetFlixDbContext.Orders.Add(order);
        await _dotNetFlixDbContext.SaveChangesAsync();

        return order;
    }

    public async Task<Order?> UpdateOrder(int id, UpdateOrderDto updateOrderDto)
    {
        var order = await _dotNetFlixDbContext.Orders
            .Include(o => o.Tickets)
            .SingleOrDefaultAsync(o => o.Id == id);

        if (order == null)
        {
            return null;
        }

        // Fetch the current tickets that need to be associated with the order
        var currentTickets = await _dotNetFlixDbContext.Tickets
            .Where(t => updateOrderDto.TicketIds.Contains(t.Id))
            .ToListAsync();

        // Check for any tickets that are already associated with a different order
        var alreadyAssignedTickets = currentTickets.Where(t => t.OrderId.HasValue && t.OrderId.Value != id);
        if (alreadyAssignedTickets.Any())
        {
            throw new InvalidOperationException("One or more tickets are already assigned to a different order.");
        }

        // Update the existing tickets to remove them from the order if they are not in the new list
        foreach (var ticket in order.Tickets.ToList())
        {
            if (!updateOrderDto.TicketIds.Contains(ticket.Id))
            {
                ticket.OrderId = null; // Disassociate the ticket from the order
            }
        }

        // Associate new tickets with the order
        foreach (var ticket in currentTickets)
        {
            if (ticket.OrderId != id)
            {
                ticket.OrderId = id; // Assign the ticket to the current order
            }
        }

        // Calculate the total price based on the sum of ticket prices
        order.TotalPrice = currentTickets.Sum(t => t.TicketPrice);

        await _dotNetFlixDbContext.SaveChangesAsync();
        return order;
    }

    public async Task<bool> DeleteOrder(int id)
    {
        var order = await _dotNetFlixDbContext.Orders
            .Include(o => o.Tickets)
            .SingleOrDefaultAsync(o => o.Id == id);

        if (order == null)
        {
            return false;
        }

        // Disassociate tickets from the order
        foreach (var ticket in order.Tickets)
        {
            ticket.OrderId = null;
        }

        _dotNetFlixDbContext.Orders.Remove(order);
        
        await _dotNetFlixDbContext.SaveChangesAsync();
        return true;
    }
}