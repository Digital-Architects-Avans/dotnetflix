namespace dotnetflix.Models.Dtos.TheaterRow;

public class UpdateTheaterRowDto
{
    public int TheaterId { get; set; }
    public int RowNumber { get; set; }
    public int NumberOfSeats { get; set; }
}