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
    public MovieType Type { get; set; }
    public bool SneakPreview { get; set; }
    public decimal BasePrice { get; set; }
    public ICollection<int> TicketIds { get; set; }

}

public enum MovieType
{
    Regular = 0,
    ThreeD = 1,
}