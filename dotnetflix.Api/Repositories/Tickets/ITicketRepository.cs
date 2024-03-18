using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos.Ticket;

namespace dotnetflix.Api.Repositories.Contracts;

public interface ITicketRepository
{
    Task<IEnumerable<Ticket>> GetTickets();
    Task<IEnumerable<Ticket>> GetTicketsForShow(int showId);
    Task<IEnumerable<Ticket>> GetTicketsForMovie(string movieTitle);
	Task<Ticket?> GetTicket(int id);
	Task<Ticket> AddTicket(AddTicketDto addTicketDto);
	Task<Ticket?> UpdateTicket(int id, UpdateTicketDto updateTicketDto);
	Task<bool> DeleteTicket(int id);
}
