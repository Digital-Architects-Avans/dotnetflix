namespace dotnetflix.Models.Dtos.Movie;

public class MovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public Rating Rating { get; set; }
    public int Runtime { get; set; }
    public string Image { get; set; }
}

public enum Rating
{
    G = 1,      // General audiences – All ages admitted
    PG = 2,     // Parental guidance suggested – Some material may not be suitable for children
    PG13 = 3,   // Parents strongly cautioned – Some material may be inappropriate for children under 13
    R = 4,      // Restricted – Under 17 requires accompanying parent or adult guardian
    NC17 = 5,   // No one 17 and under admitted
    NA = 0      // Not Available/Not Applicable
}