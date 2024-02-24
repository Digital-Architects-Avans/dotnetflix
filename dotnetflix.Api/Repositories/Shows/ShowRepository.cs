using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Shows;

public class ShowRepository:IShowRepository
{
    private readonly DotNetFlixDbContext dotNetFlixDbContext;
    public ShowRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        this.dotNetFlixDbContext = dotNetFlixDbContext;
    }
    public async Task<IEnumerable<Show>> GetShows()
    {
        var shows = await this.dotNetFlixDbContext.Shows.ToListAsync();
        return shows;
    }

    public Task<Show> GetShow(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Show> AddShow(Show show)
    {
        throw new NotImplementedException();
    }

    public Task<Show> UpdateShow(Show show)
    {
        throw new NotImplementedException();
    }

    public Task<Show> DeleteShow(int id)
    {
        throw new NotImplementedException();
    }
}