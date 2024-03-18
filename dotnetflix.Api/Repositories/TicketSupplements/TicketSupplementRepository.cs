using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.TicketSupplements;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.TicketSupplements;

public class TicketSupplementRepository : ITicketSupplementRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    public TicketSupplementRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    public async Task<IEnumerable<TicketSupplement>> GetTicketSupplements()
    {
        var ticketSupplements = await _dotNetFlixDbContext.TicketSupplements.ToListAsync();
        return ticketSupplements;
    }

    public async Task<IEnumerable<TicketSupplement>> GetTicketSupplementsForTicket(int id)
    {
        var ticketSupplements = await _dotNetFlixDbContext.TicketSupplements
            .Include(t => t.Supplement)
            .Where(t => t.TicketId == id).ToListAsync();
        return ticketSupplements;
    }

    public async Task<TicketSupplement?> GetTicketSupplement(int id)
    {
        var ticketSupplement = await _dotNetFlixDbContext.TicketSupplements.SingleOrDefaultAsync(t => t.Id == id);
        return ticketSupplement;
    }

    public async Task<TicketSupplement> AddTicketSupplement(AddTicketSupplementDto addTicketSupplementDto)
    {
        var ticketSupplement = new TicketSupplement
        {
            TicketId = addTicketSupplementDto.TicketId,
            SupplementId = addTicketSupplementDto.SupplementId
        };

        var result = await _dotNetFlixDbContext.TicketSupplements.AddAsync(ticketSupplement);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<TicketSupplement?> UpdateTicketSupplement(int id,
        UpdateTicketSupplementDto updateTicketSupplementDto)
    {
        var ticketSupplement = await _dotNetFlixDbContext.TicketSupplements.FindAsync(id);

        if (ticketSupplement != null)
        {
            ticketSupplement.TicketId = updateTicketSupplementDto.TicketId;
            ticketSupplement.SupplementId = updateTicketSupplementDto.SupplementId;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return ticketSupplement;
        }

        return null;
    }

    public async Task<bool> DeleteTicketSupplement(int id)
    {
        var ticketSupplement = await _dotNetFlixDbContext.TicketSupplements.FindAsync(id);

        if (ticketSupplement == null)
        {
            return false;
        }

        _dotNetFlixDbContext.TicketSupplements.Remove(ticketSupplement);
        await _dotNetFlixDbContext.SaveChangesAsync();

        return true;
    }
}