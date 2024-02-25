namespace dotnetflix.Models.Dtos.Show;

public class AddShowDto
{
    public int MovieId { get; set; }
    public int TheaterId { get; set; }
    public DateTime Date { get; set; }
    public int ScreenTime { get; set; }
    public MovieType Type { get; set; }
    public decimal BasePrice { get; set; }
}