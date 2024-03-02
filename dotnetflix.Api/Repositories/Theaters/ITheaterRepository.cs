using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Theater;

namespace dotnetflix.Api.Repositories.Theaters;

public interface ITheaterRepository
{
    Task<IEnumerable<Theater>> GetTheaters();
    Task<Theater?> GetTheater(int id);
    Task<Theater> AddTheater(AddTheaterDto addTheaterDto);
    Task<Theater?> UpdateTheater(int id, UpdateTheaterDto updateTheaterDto);
    Task<bool> DeleteTheater(int id);
}