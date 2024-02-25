namespace dotnetflix.Models.Dtos.Show;

public class ShowDto
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string MovieTitle { get; set; }
    public int TheaterId { get; set; }
    public string TheaterName { get; set; }
    public DateTime Date { get; set; }
    public int ScreenTime { get; set; }
    public string Type { get; set; }
    public decimal BasePrice { get; set; }
}

public enum MovieType
{
    Regular,
    ThreeD,
}