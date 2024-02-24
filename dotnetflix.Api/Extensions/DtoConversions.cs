using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Extensions;

public static class DtoConversions
{
    public static MovieDto ConvertToDto(this Movie movie)
    {
        return new MovieDto
        {
            Id = movie.Id,
            Title = movie.Title,
            Year = movie.Year,
            Description = movie.Description,
            Rating = movie.Rating.ToString(),
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
            Movie = show.Movie.Title,
            TheaterId = show.TheaterId,
            Theater = show.Theater.Name,
            Date = show.Date,
            Time = show.Time,
            Type = show.Type.ToString(),
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
}

