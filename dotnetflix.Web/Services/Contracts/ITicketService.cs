using dotnetflix.Models.Dtos;

namespace dotnetflix.Web.Services.Contracts;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>?> GetTickets();
}
