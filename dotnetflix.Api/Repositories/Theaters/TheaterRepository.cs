using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Theater;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Theaters;

public class TheaterRepository : ITheaterRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    public TheaterRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    public async Task<IEnumerable<Theater>> GetTheaters()
    {
        var theaters = await _dotNetFlixDbContext.Theaters.ToListAsync();
        return theaters;
    }

    public async Task<Theater> GetTheater(int id)
    {
        var theater = await _dotNetFlixDbContext.Theaters.SingleOrDefaultAsync(t => t.Id == id);
        return theater;
    }

    public async Task<Theater> AddTheater(AddTheaterDto addTheaterDto)
    { 
        var theater = new Theater
        {
            Name = addTheaterDto.Name,
            Seats = addTheaterDto.Seats
        };
        
        var result = await _dotNetFlixDbContext.Theaters.AddAsync(theater);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Theater> UpdateTheater(int id, UpdateTheaterDto updateTheaterDto)
    {
        var theater = await _dotNetFlixDbContext.Theaters.FindAsync(id);

        if (theater != null)
        {
            theater.Name = updateTheaterDto.Name;
            theater.Seats = updateTheaterDto.Seats;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return theater;
        }

        return null;
    }

    public async Task<Theater> DeleteTheater(int id)
    {
        var theater = await _dotNetFlixDbContext.Theaters.FindAsync(id);

        if (theater != null)
        {
            _dotNetFlixDbContext.Theaters.Remove(theater);
            await _dotNetFlixDbContext.SaveChangesAsync();
        }

        return theater;
    }
}