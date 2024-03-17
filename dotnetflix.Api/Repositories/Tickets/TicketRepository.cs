using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Repositories.Contracts;
using dotnetflix.Models.Dtos.Ticket;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Tickets;

public class TicketRepository: ITicketRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;
    
    public TicketRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }
    
    public async Task<IEnumerable<Ticket>> GetTickets()
	{
		var tickets = await _dotNetFlixDbContext.Tickets.ToListAsync();
        return tickets;
    }
    
    public async Task<IEnumerable<Ticket>> GetTicketsForShow(int showId)
    {
        var tickets = await _dotNetFlixDbContext.Tickets
            .Where(t => t.ShowId == showId)
            .Include(t => t.Supplements)
            .ToListAsync();
        return tickets;
    }
    
    public async Task<IEnumerable<Ticket>> GetTicketsForOrder(int orderId)
    {
        var tickets = await _dotNetFlixDbContext.Tickets
            .Where(t => t.OrderId == orderId)
            .Include(t => t.Supplements)
            .ToListAsync();
        return tickets;
    }
    
    public async Task<Ticket?> GetTicket(int id)
    {
        var ticket = await _dotNetFlixDbContext.Tickets.SingleOrDefaultAsync(t => t.Id == id);
        return ticket;
    }

    public async Task<Ticket> AddTicket(AddTicketDto addTicketDto)
    { 
        
        var show = await _dotNetFlixDbContext.Shows
            .Include(s => s.Movie)
            .Include(s => s.Theater)
            .SingleOrDefaultAsync(s => s.Id == addTicketDto.ShowId);

        var seat = await _dotNetFlixDbContext.Seats
            .Include(r => r.TheaterRow)
            .SingleOrDefaultAsync(s => s.Id == addTicketDto.SeatId);
        
        var supplements = await _dotNetFlixDbContext.Supplements
            .Where(s => addTicketDto.Supplements.Contains(s.Id))
            .ToListAsync();
        
        
        if (show == null || seat == null)
        {
            throw new KeyNotFoundException("The Show or Seat was not found.");
        }
        
        // Check for existing ticket for the same show and seat
        bool ticketExists = await _dotNetFlixDbContext.Tickets.AnyAsync(t => t.ShowId == addTicketDto.ShowId && t.SeatId == addTicketDto.SeatId);
        if (ticketExists)
        {
            throw new InvalidOperationException("A ticket for this seat and show already exists.");
        }
        
        var ticket = new Ticket
        {
            ShowId = addTicketDto.ShowId,
            Movie = show.Movie.Title,
            TheaterName = show.Theater.Name,
            SeatId = addTicketDto.SeatId,
            RowNumber = seat.TheaterRow.RowNumber,
            SeatNumber = seat.SeatNumber,
            ShowTime = show.Date,
            TicketTypeId = addTicketDto.TicketTypeId,
            TicketPrice = addTicketDto.TicketPrice,
            Show = show, // Assign the loaded show to the ticket
            Supplements = supplements
        };
        
        var result = await _dotNetFlixDbContext.Tickets.AddAsync(ticket);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Ticket?> UpdateTicket(int id, UpdateTicketDto updateTicketDto)
    {
        var ticket = await _dotNetFlixDbContext.Tickets.FindAsync(id);
        
        var show = await _dotNetFlixDbContext.Shows
            .Include(s => s.Movie)
            .Include(s => s.Theater)
            .SingleOrDefaultAsync(s => s.Id == updateTicketDto.ShowId);

        var seat = await _dotNetFlixDbContext.Seats
            .Include(r => r.TheaterRow)
            .SingleOrDefaultAsync(s => s.Id == updateTicketDto.SeatId);
        
        if (show == null || seat == null)
        {
            throw new KeyNotFoundException("The Show or Seat was not found.");
        }
        
        // Check for existing ticket for the same show and seat
        bool ticketExists = await _dotNetFlixDbContext.Tickets.AnyAsync(t => t.ShowId == updateTicketDto.ShowId && t.SeatId == updateTicketDto.SeatId);
        if (ticketExists)
        {
            throw new InvalidOperationException("A ticket for this seat and show already exists.");
        }

        if (ticket != null)
        {
            ticket.ShowId = updateTicketDto.ShowId;
            ticket.Movie = show.Movie.Title;
            ticket.TheaterName = show.Theater.Name;
            ticket.SeatId = updateTicketDto.SeatId;
            ticket.RowNumber = seat.TheaterRow.RowNumber;
            ticket.SeatNumber = seat.SeatNumber;
            ticket.ShowTime = show.Date;
            ticket.TicketTypeId = updateTicketDto.TicketTypeId;
            ticket.TicketPrice = updateTicketDto.TicketPrice;
            ticket.Show = show; // Assign the loaded show to the ticket
            await _dotNetFlixDbContext.SaveChangesAsync();
            return ticket;
        }

        return null;
    }

    public async Task<bool> DeleteTicket(int id)
    {
        var ticket = await _dotNetFlixDbContext.Tickets.FindAsync(id);
        
        if (ticket == null)
        {
            return false;
        }

        _dotNetFlixDbContext.Tickets.Remove(ticket);
        await _dotNetFlixDbContext.SaveChangesAsync();
        
        return true;
    }
}
