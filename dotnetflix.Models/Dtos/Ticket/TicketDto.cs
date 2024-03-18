using dotnetflix.Models.Dtos.Supplement;
using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Models.Dtos;

public class TicketDto
{
    public int Id { get; set; }
    public int ShowId { get; set; }
    public string Movie { get; set; }
    public string TheaterName { get; set; }
    public int SeatId { get; set; }
    public int RowNumber { get; set; }
    public int SeatNumber { get; set; }
    public DateTime ShowTime { get; set; }
    public int TicketTypeId { get; set; }
    public decimal TicketPrice { get; set; }
    public int? OrderId { get; set; }
}