using dotnetflix.Models.Dtos.Show;

namespace dotnetflix.Web.Services.Contracts;

public interface IShowService
{
    Task<IEnumerable<ShowDto>?> GetShows();
    Task<ShowDto>? GetShow(int id);
}