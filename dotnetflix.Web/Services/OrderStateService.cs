using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.TicketOrderDtos;
using dotnetflix.Web.Services.Contracts;

namespace dotnetflix.Web.Services;

public class OrderStateService : IOrderStateService
{
    public OrderRequestDto CurrentOrder { get; set; } = new OrderRequestDto();
    public event Action OnOrderUpdated;
    
    private void RaiseOrderUpdated()
    {
        OnOrderUpdated?.Invoke();
    }
    
    public void UpdateTicketOrder(IEnumerable<TicketOrderDto> ticketOrders)
    {
        CurrentOrder.TicketOrders = ticketOrders.ToList();
        OnOrderUpdated?.Invoke();
    }

    public void AddTicketToOrder(TicketOrderDto ticketOrder)
    {
        // Implementation to add a ticket to the current order
        OnOrderUpdated?.Invoke();
    }

    public void RemoveTicketFromOrder(int ticketTypeId)
    {
        // Implementation to remove a ticket from the current order
        OnOrderUpdated?.Invoke();
    }

    public void ClearOrder()
    {
        // Implementation to clear the current order
        CurrentOrder = new OrderRequestDto();
        OnOrderUpdated?.Invoke();
    }

    public async Task FinalizeOrderAsync()
    {
        // Implementation to finalize the order, possibly involving async operations
        // Don't forget to clear the order or perform any cleanup after finalizing
    }
}
