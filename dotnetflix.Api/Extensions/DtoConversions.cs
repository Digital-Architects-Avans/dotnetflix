using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Order;
using dotnetflix.Models.Dtos.Show;
using dotnetflix.Models.Dtos.Theater;

namespace dotnetflix.Api.Extensions;

public static class DtoConversions
{
    public static IEnumerable<MovieDto> ConvertToDto(this IEnumerable<Movie> movies)
    {
        return movies.Select(movie => movie.ConvertToDto()).ToList();
    }

    public static IEnumerable<TheaterDto> ConvertToDto(this IEnumerable<Theater> theaters)
    {
        return theaters.Select(theater => theater.ConvertToDto());
    }

    public static IEnumerable<ShowDto> ConvertToDto(this IEnumerable<Show> shows, IEnumerable<Movie> movies,
        IEnumerable<Theater> theaters)
    {
        return (from show in shows
            join movie in movies on show.MovieId equals movie.Id
            join theater in theaters on show.TheaterId equals theater.Id
            select new ShowDto
            {
                Id = show.Id,
                MovieId = show.MovieId,
                MovieTitle = movie.Title,
                TheaterId = show.TheaterId,
                TheaterName = theater.Name,
                Date = show.Date,
                ScreenTime = show.ScreenTime,
                Type = show.Type,
                BasePrice = show.BasePrice
            }).ToList();
    }

	public static IEnumerable<TicketDto> ConvertToDto
    (this
		IEnumerable<Ticket> tickets,
		IEnumerable<Movie> movies,
		IEnumerable<Show> shows,
		IEnumerable<Theater> theaters,
		IEnumerable<Seat> seats
    )
	{
		return (from ticket in tickets
				join movie in movies on ticket.MovieId equals movie.Id
				join show in shows on ticket.ShowId equals show.Id
				join theater in theaters on ticket.TheaterId equals theater.Id
                join seat in seats on ticket.SeatId equals seat.Id
				select new TicketDto
				{
					Id = ticket.Id,
					MovieId = ticket.MovieId,
                    MovieTitle = movie.Title,
                    MovieRuntime = movie.Runtime,
					ShowId = ticket.ShowId,
                    ShowDate = show.Date,
                    BasePrice = show.BasePrice,
					Discount = ticket.Discount,
					TheaterId = ticket.TheaterId,
                    SeatId = ticket.SeatId,
					Row = ticket.Row
				}).ToList();
	}


	public static MovieDto ConvertToDto(this Movie movie)
    {
        return new MovieDto
        {
            Id = movie.Id,
            Title = movie.Title,
            Year = movie.Year,
            Description = movie.Description,
            Rating = movie.Rating,
            Runtime = movie.Runtime,
            Image = movie.Image
        };
    }

    public static ShowDto ConvertToDto(this Show show)
    {
        return new ShowDto
        {
            Id = show.Id,
            MovieId = show.MovieId,
            MovieTitle = show.Movie.Title,
            TheaterId = show.TheaterId,
            TheaterName = show.Theater.Name,
            Date = show.Date,
            ScreenTime = show.ScreenTime,
            Type = show.Type,
            BasePrice = show.BasePrice
        };
    }

    public static TheaterDto ConvertToDto(this Theater theater)
    {
        return new TheaterDto
        {
            Id = theater.Id,
            Name = theater.Name,
            Seats = theater.Seats
        };
    }

	public static TicketDto ConvertToDto(this Ticket ticket)
	{
		return new TicketDto
        {
			Id = ticket.Id,
			MovieId = ticket.MovieId,
			ShowId = ticket.ShowId,
			TheaterId = ticket.TheaterId,
			SeatId = ticket.SeatId,
			Row = ticket.Row
		};
	}
    
    public static OrderDto ConvertToDto(this Order order)
    {
		return new OrderDto
        {
			Id = order.Id,
			TotalPrice = order.TotalPrice
		};
	}
}