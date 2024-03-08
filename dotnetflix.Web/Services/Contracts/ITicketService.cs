using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Ticket;
using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Web.Services.Contracts;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>?> GetTickets();
    Task<IEnumerable<TicketTypeDto>> GetTicketTypes();
    Task<List<TicketDto>> GenerateTickets(OrderRequestDto orderRequestDto);
}
