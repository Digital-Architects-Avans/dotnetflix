using dotnetflix.Api.Data.Entities;

namespace dotnetflix.Api.Repositories.Theaters;

public interface ITheaterRepository
{
    Task<IEnumerable<Theater>> GetTheaters();
    Task<Theater> GetTheater(int id);
    Task<Theater> AddTheater(Theater theater);
    Task<Theater> UpdateTheater(Theater theater);
    Task<Theater> DeleteTheater(int id);
}