using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.TicketOrderDtos;

namespace dotnetflix.Web.Services.Contracts;

public interface IOrderStateService
{
    OrderRequestDto CurrentOrder { get; set; }
    event Action OnOrderUpdated;
    void AddTicketToOrder(TicketOrderDto ticketOrder);
    void UpdateTicketOrder(IEnumerable<TicketOrderDto> ticketOrders);
    void RemoveTicketFromOrder(int ticketTypeId);
    void ClearOrder();
    Task FinalizeOrderAsync();
}