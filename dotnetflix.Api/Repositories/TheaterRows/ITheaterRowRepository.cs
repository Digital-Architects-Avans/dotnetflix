using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.TheaterRow;

namespace dotnetflix.Api.Repositories.TheaterRows;

public interface ITheaterRowRepository
{
    Task<IEnumerable<TheaterRow>> GetTheaterRows();
    Task<IEnumerable<TheaterRow>> GetTheaterRowsForTheater(int theaterId);
    Task<TheaterRow?> GetTheaterRow(int id);
    Task<TheaterRow> AddTheaterRow(AddTheaterRowDto addTheaterRowDto);
    Task<TheaterRow?> UpdateTheaterRow(int id, UpdateTheaterRowDto updateTheaterRowDto);
    Task<bool> DeleteTheaterRow(int id);
}