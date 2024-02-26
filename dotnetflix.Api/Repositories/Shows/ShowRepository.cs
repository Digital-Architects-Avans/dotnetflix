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

    public async Task<IEnumerable<Show>> GetShows()
    {
        var shows = await _dotNetFlixDbContext.Shows.ToListAsync();
        return shows;
    }

    public async Task<Show> GetShow(int id)
    {
        return await (from show in _dotNetFlixDbContext.Shows
            join movie in _dotNetFlixDbContext.Movies on show.MovieId equals movie.Id
            join theater in _dotNetFlixDbContext.Theaters on show.TheaterId equals theater.Id
            where show.Id == id
            select new Show
            {
                Id = show.Id,
                MovieId = show.MovieId,
                Movie = movie,
                TheaterId = show.TheaterId,
                Theater = theater,
                Date = show.Date,
                ScreenTime = show.ScreenTime,
                Type = show.Type,
                BasePrice = show.BasePrice
            }).SingleOrDefaultAsync();
    }

    public async Task<Show> AddShow(AddShowDto addShowDto)
    {
        var show = await (from movie in _dotNetFlixDbContext.Movies
            where movie.Id == addShowDto.MovieId
            from theater in _dotNetFlixDbContext.Theaters
            where theater.Id == addShowDto.TheaterId
            select new Show
            {
                MovieId = addShowDto.MovieId,
                Movie = movie,
                TheaterId = addShowDto.TheaterId,
                Theater = theater,
                Date = addShowDto.Date,
                ScreenTime = addShowDto.ScreenTime,
                Type = addShowDto.Type,
                BasePrice = addShowDto.BasePrice
            }).SingleOrDefaultAsync();

        if (show != null)
        {
            var result = await _dotNetFlixDbContext.Shows.AddAsync(show);
            await _dotNetFlixDbContext.SaveChangesAsync();
            return result.Entity;
        }

        return null;
    }


    public async Task<Show> UpdateShow(int id, UpdateShowDto updateShowDto)
    {
        var show = await _dotNetFlixDbContext.Shows.FindAsync(id);
        
        if (show != null)
        {
            show.MovieId = updateShowDto.MovieId;
            show.TheaterId = updateShowDto.TheaterId;
            show.Date = updateShowDto.Date;
            show.ScreenTime = updateShowDto.ScreenTime;
            show.Type = updateShowDto.Type;
            show.BasePrice = updateShowDto.BasePrice;
            await _dotNetFlixDbContext.SaveChangesAsync();
            return show;
        }

        return null;
    }

    public async Task<Show> DeleteShow(int id)
    {
        var show = await _dotNetFlixDbContext.Shows.FindAsync(id);

        if (show != null)
        {
            _dotNetFlixDbContext.Shows.Remove(show);
            await _dotNetFlixDbContext.SaveChangesAsync();
        }

        return show;
    }
}