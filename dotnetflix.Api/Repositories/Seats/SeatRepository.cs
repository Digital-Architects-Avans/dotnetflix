using dotnetflix.Api.Data;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos.Seat;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Seats;

public class SeatRepository : ISeatRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    public SeatRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    public async Task<IEnumerable<Seat>> GetSeats()
    {
        var seats = await _dotNetFlixDbContext.Seats.ToListAsync();
        return seats;
    }
    
    public async Task<IEnumerable<Seat>> GetSeatsForTheater(int theaterId)
    {
        var seats = await _dotNetFlixDbContext.Seats
            .Include(s => s.TheaterRow)
            .Where(s => s.TheaterRow.TheaterId == theaterId)
            .ToListAsync();
        return seats;
    }

    public async Task<Seat?> GetSeat(int id)
    {
        var seat = await _dotNetFlixDbContext.Seats.SingleOrDefaultAsync(s => s.Id == id);
        return seat;
    }

    public async Task<Seat> AddSeat(AddSeatDto addSeatDto)
    {
        var seat = new Seat
        {
            TheaterRowId = addSeatDto.TheaterRowId,
            SeatNumber = addSeatDto.SeatNumber
        };

        var result = await _dotNetFlixDbContext.Seats.AddAsync(seat);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Seat?> UpdateSeat(int id, UpdateSeatDto updateSeatDto)
    {
        var seat = await _dotNetFlixDbContext.Seats.FindAsync(id);

        if (seat != null)
        {
            seat.TheaterRowId = updateSeatDto.TheaterRowId;
            seat.SeatNumber = updateSeatDto.SeatNumber;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return seat;
        }

        return null;
    }

    public async Task<bool> DeleteSeat(int id)
    {
        var seat = await _dotNetFlixDbContext.Seats.FindAsync(id);

        if (seat == null)
        {
            return false;
        }

        _dotNetFlixDbContext.Seats.Remove(seat);
        await _dotNetFlixDbContext.SaveChangesAsync();

        return true;
    }
}