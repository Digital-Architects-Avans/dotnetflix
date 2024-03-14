using dotnetflix.Models.Dtos.Seat;
using dotnetflix.Models.Dtos.TheaterRow;

namespace dotnetflix.Web.Services.Contracts;

public interface ISeatService
{
    Task<IEnumerable<SeatDto>?> GetAllSeatsForTheater(int theaterId);
    Task<IEnumerable<SeatDto>?> GetAvailableSeatsForShow(int showId);
    Task<IEnumerable<TheaterRowDto>?> GetAllTheaterRowsForTheater(int theaterId);
}