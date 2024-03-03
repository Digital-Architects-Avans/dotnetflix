using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.TicketType;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.TicketTypes;

public class TicketTypeRepository: ITicketTypeRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;
    
    public TicketTypeRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }
    
    public async Task<IEnumerable<TicketType>> GetTicketTypes()
    {
        var ticketTypes = await _dotNetFlixDbContext.TicketTypes.ToListAsync();
        return ticketTypes;
    }

    public async Task<TicketType?> GetTicketType(int id)
    {
        var ticketTypes = await _dotNetFlixDbContext.TicketTypes.SingleOrDefaultAsync(t => t.Id == id);
        return ticketTypes;
    }

    public async Task<TicketType> AddTicketType(AddTicketTypeDto addTicketTypeDto)
    {
        var ticketType = new TicketType
        {
            Name = addTicketTypeDto.Name,
            Discount = addTicketTypeDto.Discount
        };
        
        var result = await _dotNetFlixDbContext.TicketTypes.AddAsync(ticketType);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<TicketType?> UpdateTicketType(int id, UpdateTicketTypeDto updateTicketTypeDto)
    {
        var ticketType = await _dotNetFlixDbContext.TicketTypes.FindAsync(id);

        if (ticketType != null)
        {
            ticketType.Name = updateTicketTypeDto.Name;
            ticketType.Discount = updateTicketTypeDto.Discount;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return ticketType;
        }

        return null;
    }

    public async Task<bool> DeleteTicketType(int id)
    {
        var ticketType = await _dotNetFlixDbContext.TicketTypes.FindAsync(id);
        
        if (ticketType == null)
        {
            return false;
        }

        _dotNetFlixDbContext.TicketTypes.Remove(ticketType);
        await _dotNetFlixDbContext.SaveChangesAsync();
        
        return true;
    }
}