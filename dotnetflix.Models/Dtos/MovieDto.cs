namespace dotnetflix.Models.Dtos;

public class MovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public string Rating { get; set; }
    public int Runtime { get; set; }
    public string Image { get; set; }
    
}