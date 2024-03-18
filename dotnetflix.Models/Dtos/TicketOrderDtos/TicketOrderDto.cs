namespace dotnetflix.Models.Dtos.TicketOrderDtos;

public class TicketOrderDto
{
    public int MovieId { get; set; }
    public string MovieTitle { get; set; }
    public int TheaterId { get; set; }
    public string TheaterName { get; set; }
    public DateTime ShowTime { get; set; }
    public int ShowId { get; set; }
    public int SeatId { get; set; }
    public int RowNumber { get; set; }
    public int SeatNumber { get; set; }
    public int TicketTypeId { get; set; }
    public int Quantity { get; set; }
    public decimal FinalPrice { get; set; } // Price for the ticket after discount applied to Show Base Price
    public ICollection<int> SupplementIds { get; set; } = new List<int>(); // List of Supplement Ids
}