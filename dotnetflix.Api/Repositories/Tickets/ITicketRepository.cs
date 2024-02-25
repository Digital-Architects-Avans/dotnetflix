using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Entities;

namespace dotnetflix.Api.Repositories.Contracts;

public interface ITicketRepository
{
    // FETCH LISTS OF OBJECTS
    Task<IEnumerable<Ticket>> GetTickets();
    Task<IEnumerable<Movie>> GetMovies();
    Task<IEnumerable<Show>> GetShows();
    Task<IEnumerable<Theater>> GetTheaters();
	Task<IEnumerable<Seat>> GetSeats();

	// GET INDIVIDUAL ITEMS
	Task<Ticket> GetTicket(int id);
    Task<Movie> GetMovie(int id);
    Task<Show> GetShow(int id);
    Task<Theater> GetTheater(int id);
	Task<Seat> GetSeat(int id);
}
