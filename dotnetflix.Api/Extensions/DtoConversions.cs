using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos;

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
    
    public static Movie ConvertToEntity(this MovieDto movieDto)
    {
        return new Movie
        {
            Id = movieDto.Id,
            Title = movieDto.Title,
            Year = movieDto.Year,
            Description = movieDto.Description,
            // Rating = movieDto.Rating,
            Runtime = movieDto.Runtime,
            Image = movieDto.Image
            // Map other properties as needed
        };
    }

    public static Theater ConvertToEntity(this TheaterDto theaterDto)
    {
        return new Theater
        {
            Id = theaterDto.Id,
            Name = theaterDto.Name,
            Seats = theaterDto.Seats
            // Map other properties as needed
        };
    }

    public static Show ConvertToEntity(this ShowDto showDto)
    {
        return new Show
        {
            Id = showDto.Id,
            MovieId = showDto.MovieId,
            TheaterId = showDto.TheaterId,
            Date = showDto.Date,
            Time = showDto.Time,
            // Type = showDto.Type,
            BasePrice = showDto.BasePrice
            // Map other properties as needed
        };
    }
    
}

