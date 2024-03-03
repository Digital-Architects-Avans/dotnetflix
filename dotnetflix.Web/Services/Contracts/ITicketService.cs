using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Web.Services.Contracts;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>?> GetTickets();
    Task<IEnumerable<TicketTypeDto>> GetTicketTypes();
}
