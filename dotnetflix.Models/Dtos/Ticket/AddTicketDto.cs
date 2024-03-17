using dotnetflix.Models.Dtos.TicketType;

namespace dotnetflix.Models.Dtos.Ticket;

public class AddTicketDto
{
	public int ShowId { get; set; }
	public int SeatId { get; set; }
	public int TicketTypeId { get; set; }
	public decimal TicketPrice { get; set; }
	public int? OrderId { get; set; }
	public ICollection<int> Supplements { get; set; }
}
