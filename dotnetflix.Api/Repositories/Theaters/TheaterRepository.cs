using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Theaters;

public class TheaterRepository: ITheaterRepository
{
    private readonly DotNetFlixDbContext dotNetFlixDbContext;
    public TheaterRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        this.dotNetFlixDbContext = dotNetFlixDbContext;
    }
    public async Task<IEnumerable<Theater>> GetTheaters()
    {
        var theaters = await this.dotNetFlixDbContext.Theaters.ToListAsync();
        return theaters;
    }

    public Task<Theater> GetTheater(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Theater> AddTheater(Theater theater)
    {
        throw new NotImplementedException();
    }

    public Task<Theater> UpdateTheater(Theater theater)
    {
        throw new NotImplementedException();
    }

    public Task<Theater> DeleteTheater(int id)
    {
        throw new NotImplementedException();
    }
}