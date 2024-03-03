using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Ticket;
using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Api.Repositories.TicketTypes;

public interface ITicketTypeRepository
{
    Task<IEnumerable<TicketType>> GetTicketTypes();
    Task<TicketType?> GetTicketType(int id);
    Task<TicketType> AddTicketType(AddTicketTypeDto addTicketTypeDto);
    Task<TicketType?> UpdateTicketType(int id, UpdateTicketTypeDto updateTicketTypeDto);
    Task<bool> DeleteTicketType(int id);
}
