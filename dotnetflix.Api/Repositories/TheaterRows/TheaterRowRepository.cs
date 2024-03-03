using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.TheaterRow;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.TheaterRows;


public class TheaterRowRepository : ITheaterRowRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;
    
    public TheaterRowRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }
    
    public async Task<IEnumerable<TheaterRow>> GetTheaterRows()
    {
        var theaterRows = await _dotNetFlixDbContext.TheaterRows.ToListAsync();
        return theaterRows;
    }

    public async Task<TheaterRow?> GetTheaterRow(int id)
    {
        var theaterRow = await _dotNetFlixDbContext.TheaterRows.SingleOrDefaultAsync(t => t.Id == id);
        return theaterRow;
    }

    public async Task<TheaterRow> AddTheaterRow(AddTheaterRowDto addTheaterRowDto)
    {
        var theaterRow = new TheaterRow
        {
            TheaterId = addTheaterRowDto.TheaterId,
            RowNumber = addTheaterRowDto.RowNumber,
            NumberOfSeats = addTheaterRowDto.NumberOfSeats
        };
        
        var result = await _dotNetFlixDbContext.TheaterRows.AddAsync(theaterRow);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<TheaterRow?> UpdateTheaterRow(int id, UpdateTheaterRowDto updateTheaterRowDto)
    {
        var theaterRow = await _dotNetFlixDbContext.TheaterRows.FindAsync(id);

        if (theaterRow != null)
        {
            theaterRow.TheaterId = updateTheaterRowDto.TheaterId;
            theaterRow.RowNumber = updateTheaterRowDto.RowNumber;
            theaterRow.NumberOfSeats = updateTheaterRowDto.NumberOfSeats;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return theaterRow;
        }

        return null;
    }

    public async Task<bool> DeleteTheaterRow(int id)
    {
        var theaterRow = await _dotNetFlixDbContext.TheaterRows.FindAsync(id);
        
        if (theaterRow == null)
        {
            return false;
        }

        _dotNetFlixDbContext.TheaterRows.Remove(theaterRow);
        await _dotNetFlixDbContext.SaveChangesAsync();
        
        return true;
    }
}