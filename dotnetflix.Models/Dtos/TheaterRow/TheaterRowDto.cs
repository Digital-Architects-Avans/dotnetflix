namespace dotnetflix.Models.Dtos.TheaterRow;

public class TheaterRowDto
{
    public int Id { get; set; }
    
    public string TheaterName { get; set; }
    public int TheaterId { get; set; }
    
    public int RowNumber { get; set; }
    
    public int ActualSeatCount { get; set; } 
    
    public int NumberOfSeats { get; set; }
    
}