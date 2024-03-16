using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Seat;
using dotnetflix.Models.Dtos.TheaterRow;
using dotnetflix.Models.Dtos.TicketType;
using dotnetflix.Models.Dtos.Supplement;

namespace dotnetflix.Web.Services.Contracts;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>?> GetTickets();
    Task<IEnumerable<TicketDto>?> GetTicketsForShow(int showId);
    Task<IEnumerable<TicketTypeDto>?> GetTicketTypes();
    Task<IEnumerable<SupplementDto>?> GetSupplements();
    Task<List<TicketDto>> GenerateTickets(OrderRequestDto orderRequestDto);
}
