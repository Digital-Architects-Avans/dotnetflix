using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Order;
using dotnetflix.Models.Dtos.Review;
using dotnetflix.Models.Dtos.Seat;
using dotnetflix.Models.Dtos.Show;
using dotnetflix.Models.Dtos.Subscriber;
using dotnetflix.Models.Dtos.Supplement;
using dotnetflix.Models.Dtos.Theater;
using dotnetflix.Models.Dtos.TheaterRow;
using dotnetflix.Models.Dtos.Ticket;
using dotnetflix.Models.Dtos.TicketSupplements;
using dotnetflix.Models.Dtos.TicketType;
using System.Collections.Generic;

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

    public static IEnumerable<ShowDto> ConvertToDto(this IEnumerable<Show> shows)
    {
	    return shows.Select(show => show.ConvertToDto());
    }
    
	public static IEnumerable<TicketDto> ConvertToDto(this IEnumerable<Ticket> tickets)
	{
		return tickets.Select(ticket => ticket.ConvertToDto()).ToList();
	}
	
	public static IEnumerable<OrderDto> ConvertToDto(this IEnumerable<Order> orders)
	{
		return orders.Select(order => order.ConvertToDto()).ToList();
	}
	
	public static IEnumerable<TheaterRowDto> ConvertToDto(this IEnumerable<TheaterRow> theaterRows)
	{
		return theaterRows.Select(theaterRow => theaterRow.ConvertToDto()).ToList();
	}
	
	public static IEnumerable<TicketTypeDto> ConvertToDto(this IEnumerable<TicketType> ticketTypes)
	{
		return ticketTypes.Select(ticketType => ticketType.ConvertToDto()).ToList();
	}
	
	public static IEnumerable<SeatDto> ConvertToDto(this IEnumerable<Seat> seats)
	{
		return seats.Select(seat => seat.ConvertToDto()).ToList();
	}
	
	public static IEnumerable<SupplementDto> ConvertToDto(this IEnumerable<Supplement> supplements)
	{
		return supplements.Select(supplement => supplement.ConvertToDto()).ToList();
	}
	
	public static IEnumerable<TicketSupplementDto> ConvertToDto(this IEnumerable<TicketSupplement> ticketSupplements)
	{
		return ticketSupplements.Select(ticketSupplement => ticketSupplement.ConvertToDto()).ToList();
	}

	public static IEnumerable<ReviewDto> ConvertToDto(this IEnumerable<Review> reviews)
	{
		return reviews.Select(review => review.ConvertToDto()).ToList();
	}

    public static IEnumerable<SubscriberDto> ConvertToDto(this IEnumerable<Subscriber> subscribers)
    {
        return subscribers.Select(subscriber => subscriber.ConvertToDto()).ToList();
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
            SpokenLanguages = movie.SpokenLanguages,
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
            SneakPreview = show.SneakPreview,
            BasePrice = show.BasePrice,
            TicketIds = show.Tickets.Select(t => t.Id).ToList()
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
			ShowId = ticket.ShowId,
			Movie = ticket.Movie,
			TheaterName = ticket.TheaterName,
			RowNumber = ticket.RowNumber,
			SeatId = ticket.SeatId,
			SeatNumber = ticket.SeatNumber,
			ShowTime = ticket.ShowTime,
			TicketTypeId = ticket.TicketTypeId,
			TicketPrice = ticket.TicketPrice,
			OrderId = ticket.OrderId
		};
	}
    
    public static OrderDto ConvertToDto(this Order order)
    {
		return new OrderDto
        {
			Id = order.Id,
			TotalPrice = order.TotalPrice,
			TicketIds = order.Tickets.Select(t => t.Id).ToList(),
			CustomerName = order.CustomerName,
			CustomerEmail = order.CustomerEmail,
			Uuid = order.Uuid
		};
	}
    
    public static TheaterRowDto ConvertToDto(this TheaterRow theaterRow)
    {
	    return new TheaterRowDto
	    {
		    Id = theaterRow.Id,
		    TheaterId = theaterRow.TheaterId,
		    RowNumber = theaterRow.RowNumber,
		    NumberOfSeats = theaterRow.NumberOfSeats
	    };
    }
    
    public static TicketTypeDto ConvertToDto(this TicketType ticketType)
    {
	    return new TicketTypeDto
	    {
		    Id = ticketType.Id,
		    Name = ticketType.Name,
		    Discount = ticketType.Discount
	    };
    }
    
    public static SeatDto ConvertToDto(this Seat seat)
    {
	    return new SeatDto
	    {
		    Id = seat.Id,
		    TheaterRowId = seat.TheaterRowId,
		    RowNumber = seat.TheaterRow.RowNumber,
		    SeatNumber = seat.SeatNumber
	    };
    }
    
    public static SupplementDto ConvertToDto(this Supplement supplement)
	{
	    return new SupplementDto
	    {
		    Id = supplement.Id,
		    Name = supplement.Name,
		    Price = supplement.Price
	    };
	}
    
	public static TicketSupplementDto ConvertToDto(this TicketSupplement ticketSupplement)
	{
		return new TicketSupplementDto
		{
			Id = ticketSupplement.Id,
			TicketId = ticketSupplement.TicketId,
			SupplementId = ticketSupplement.SupplementId
		};
	}

    public static ReviewDto ConvertToDto(this Review review)
	{
	    return new ReviewDto
	    {
		    Id = review.Id,
		    Name = review.Name,
		    ReviewText = review.ReviewText,
		    Stars = review.Stars
	    };
	}
    
    public static SubscriberDto ConvertToDto(this Subscriber subscriber)
	{
		return new SubscriberDto
		{
			Id = subscriber.Id,
			Name = subscriber.Name,
			Email = subscriber.Email
		};
	}

}