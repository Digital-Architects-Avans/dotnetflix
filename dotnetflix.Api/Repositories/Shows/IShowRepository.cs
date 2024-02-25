using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Show;

namespace dotnetflix.Api.Repositories.Shows;

public interface IShowRepository
{
    Task<IEnumerable<Show>> GetShows();
    Task<Show> GetShow(int id);
    Task<Show> AddShow(AddShowDto addShowDto);
    Task<Show> UpdateShow(int id, UpdateShowDto updateShowDto);
    Task<Show> DeleteShow(int id);
}