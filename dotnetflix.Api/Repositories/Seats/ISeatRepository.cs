using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Seat;

namespace dotnetflix.Api.Repositories.Seats;

public interface ISeatRepository
{
    Task<IEnumerable<Seat>> GetSeats();
    Task<IEnumerable<Seat>> GetSeatsForTheater(int theaterId);
    Task<Seat?> GetSeat(int id);
    Task<Seat> AddSeat(AddSeatDto addSeatDto);
    Task<Seat?> UpdateSeat(int id, UpdateSeatDto updateSeatDto);
    Task<bool> DeleteSeat(int id);
}
