namespace dotnetflix.Models.Dtos.Ticket;

public class AddTicketDto
{
	public int ShowId { get; set; }
	public int SeatId { get; set; }
	public Discount Discount { get; set; }
	public decimal TicketPrice { get; set; }
}
