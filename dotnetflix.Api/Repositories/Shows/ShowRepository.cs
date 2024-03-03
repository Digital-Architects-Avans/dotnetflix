using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Show;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Shows;

public class ShowRepository : IShowRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    public ShowRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    // Eagerly load the navigation properties using Include
    public async Task<IEnumerable<Show>> GetShows()
    {
        var shows = await _dotNetFlixDbContext.Shows
            .Include(s => s.Movie)
            .Include(s => s.Theater) 
            .Include(s => s.Tickets)  
            .ToListAsync();
        return shows;
    }

    public async Task<Show?> GetShow(int id)
    {
        // Using eager loading to simplify the query
        return await _dotNetFlixDbContext.Shows
            .Include(s => s.Movie)
            .Include(s => s.Theater)
            .Include(s => s.Tickets) 
            .AsNoTracking() // Added for read-only operation
            .SingleOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Show> AddShow(AddShowDto addShowDto)
    {
        
        var movie = await _dotNetFlixDbContext.Movies.SingleOrDefaultAsync(m => m.Id == addShowDto.MovieId);
        var theater = await _dotNetFlixDbContext.Theaters.SingleOrDefaultAsync(t => t.Id == addShowDto.TheaterId);
        
        if (movie == null || theater == null)
        {
            throw new KeyNotFoundException("The Movie or Theater was not found.");
        }
        
        var show = new Show
        {
            MovieId = addShowDto.MovieId,
            TheaterId = addShowDto.TheaterId,
            Date = addShowDto.Date,
            ScreenTime = addShowDto.ScreenTime,
            Type = addShowDto.Type,
            BasePrice = addShowDto.BasePrice,
            Movie = movie,
            Theater = theater,
            Tickets = new List<Ticket>()
        };
        
       var result = await _dotNetFlixDbContext.Shows.AddAsync(show);
        await _dotNetFlixDbContext.SaveChangesAsync();
        return result.Entity;

    }


    public async Task<Show?> UpdateShow(int id, UpdateShowDto updateShowDto)
    {
        var show = await _dotNetFlixDbContext.Shows
            .Include(s => s.Movie)
            .Include(s => s.Theater)
            .Include(s => s.Tickets) // Ensure Tickets are loaded
            .SingleOrDefaultAsync(s => s.Id == id);
        
        var movie = await _dotNetFlixDbContext.Movies.SingleOrDefaultAsync(m => m.Id == updateShowDto.MovieId);
        var theater = await _dotNetFlixDbContext.Theaters.SingleOrDefaultAsync(t => t.Id == updateShowDto.TheaterId);

        if (movie == null || theater == null)
        {
            throw new KeyNotFoundException("The Movie or Theater was not found.");
        }

        if (show != null)
        {
            show.MovieId = updateShowDto.MovieId;
            show.TheaterId = updateShowDto.TheaterId;
            show.Date = updateShowDto.Date;
            show.ScreenTime = updateShowDto.ScreenTime;
            show.Type = updateShowDto.Type;
            show.BasePrice = updateShowDto.BasePrice;
            show.Movie = movie;
            show.Theater = theater;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return show;
        }

        return null;
    }

    public async Task<bool> DeleteShow(int id)
    {
        var show = await _dotNetFlixDbContext.Shows.FindAsync(id);
        
        if (show == null)
        {
            return false;
        }

        _dotNetFlixDbContext.Shows.Remove(show);
        await _dotNetFlixDbContext.SaveChangesAsync();
        
        return true;
    }
}