namespace dotnetflix.Models.Dtos.Seat;

public class SeatDto
{
    public int Id { get; set; }
    public int TheaterRowId { get; set; }
    public int RowNumber { get; set; }
    public int SeatNumber { get; set; }
}