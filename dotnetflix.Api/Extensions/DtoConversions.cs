using dotnetflix.Api.Data.Entities;
using dotnetflix.Models.Dtos.Movie;
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
                Type = show.Type.ToString(),
                BasePrice = show.BasePrice
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