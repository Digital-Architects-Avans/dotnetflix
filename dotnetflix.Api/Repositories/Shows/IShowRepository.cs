using dotnetflix.Api.Data.Entities;

namespace dotnetflix.Api.Repositories.Shows;

public interface IShowRepository
{
    Task<IEnumerable<Show>> GetShows();
    Task<Show> GetShow(int id);
    Task<Show> AddShow(Show show);
    Task<Show> UpdateShow(Show show);
    Task<Show> DeleteShow(int id);
}