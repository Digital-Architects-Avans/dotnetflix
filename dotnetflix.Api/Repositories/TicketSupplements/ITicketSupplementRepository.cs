using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.TicketSupplements;

namespace dotnetflix.Api.Repositories.TicketSupplements;

public interface ITicketSupplementRepository
{
    Task<IEnumerable<TicketSupplement>> GetTicketSupplements();
    Task<IEnumerable<TicketSupplement>> GetTicketSupplementsForTicket(int id);
    Task<TicketSupplement?> GetTicketSupplement(int id);
    Task<TicketSupplement> AddTicketSupplement(AddTicketSupplementDto addTicketSupplementDto);
    Task<TicketSupplement?> UpdateTicketSupplement(int id, UpdateTicketSupplementDto updateTicketSupplementDto);
    Task<bool> DeleteTicketSupplement(int id);
}