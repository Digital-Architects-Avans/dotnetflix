namespace dotnetflix.Models.Dtos.TheaterRow;

public class AddTheaterRowDto
{
    public int TheaterId { get; set; }
    public int RowNumber { get; set; }
    public int NumberOfSeats { get; set; }
}