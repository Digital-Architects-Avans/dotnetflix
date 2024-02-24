namespace dotnetflix.Models.Dtos;

public class ShowDto
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    // public string Movie { get; set; }
    public int TheaterId { get; set; }
    // public string Theater { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Type { get; set; }
    public decimal BasePrice { get; set; }
}

public enum MovieType
{
    Regular,
    ThreeD,
}