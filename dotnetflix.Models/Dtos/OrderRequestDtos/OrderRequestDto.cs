using dotnetflix.Models.Dtos.TicketOrderDtos;

namespace dotnetflix.Models.Dtos.OrderRequestDtos;

public class OrderRequestDto
{
    public List<TicketOrderDto> TicketOrders { get; set; } = new List<TicketOrderDto>();
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }

}