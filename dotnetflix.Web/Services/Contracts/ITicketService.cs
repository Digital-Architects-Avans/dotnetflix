using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.OrderRequestDtos;
using dotnetflix.Models.Dtos.Seat;
using dotnetflix.Models.Dtos.TheaterRow;
using dotnetflix.Models.Dtos.TicketType;
using dotnetflix.Models.Dtos.Supplement;
using dotnetflix.Models.Dtos.TicketSupplements;

namespace dotnetflix.Web.Services.Contracts;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>?> GetTickets();
    Task<TicketDto?> GetTicket(int id);
    Task<IEnumerable<TicketDto>?> GetTicketsForShow(int showId);
    Task<IEnumerable<TicketDto>?> GetTicketsForOrder(int orderId);
    Task<IEnumerable<TicketTypeDto>?> GetTicketTypes();
    Task<IEnumerable<SupplementDto>?> GetSupplements();
    Task<IEnumerable<SupplementDto>?> GetSupplementDtosForTicket(int id);
    Task<List<TicketDto>> GenerateTickets(OrderRequestDto orderRequestDto);
}
