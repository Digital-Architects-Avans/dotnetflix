namespace dotnetflix.Models.Dtos.Movie;

public class AddMovieDto
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public Rating Rating { get; set; }
    public int Runtime { get; set; }
    public string SpokenLanguages { get; set; }
    public string Image { get; set; }
}

