using dotnetflix.Api.Data;
using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Repositories.Contracts;

public class TicketRepository
{
    private readonly DotNetFlixDbContext _dotNetFlixDbContext;

    // CREATE DATABASE REFERENCE
    public TicketRepository(DotNetFlixDbContext dotNetFlixDbContext)
    {
        _dotNetFlixDbContext = dotNetFlixDbContext;
    }

    // GET LISTS OF TICKETS+MOVIES+SHOWS+THEATERS
    public async Task<IEnumerable<Ticket>> GetTickets()
	{
		var tickets = await _dotNetFlixDbContext.Tickets.ToListAsync();
        return tickets;
    }
    public async Task<IEnumerable<Movie>> GetMovies()
    {
        var movies = await _dotNetFlixDbContext.Movies.ToListAsync();
        return movies;
    }

    public async Task<IEnumerable<Show>> GetShows()
    {
        var shows = await _dotNetFlixDbContext.Shows.ToListAsync();
        return shows;
    }

    public async Task<IEnumerable<Theater>> GetTheaters()
    {
        var theaters = await _dotNetFlixDbContext.Theaters.ToListAsync();
        return theaters;
    }

	public async Task<IEnumerable<Seat>> GetSeats()
	{
		var seats = await _dotNetFlixDbContext.Seats.ToListAsync();
		return seats;
	}

	// GET SINGLE TICKET+MOVIE+SHOW+THEATER
	public Task<Ticket> GetTicket(int id)
    {
        throw new NotImplementedException();
    }
    public Task<Movie> GetMovie(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Show> GetShow(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Theater> GetTheater(int id)
    {
        throw new NotImplementedException();
    }

	public Task<Theater> GetSeat(int id)
	{
		throw new NotImplementedException();
	}
}
