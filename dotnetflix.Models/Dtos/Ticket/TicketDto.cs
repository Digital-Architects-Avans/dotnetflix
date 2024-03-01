namespace dotnetflix.Models.Dtos;

public class TicketDto
{
	public int Id { get; set; }
	public int ShowId { get; set; }
	public int OrderId { get; set; }
	public int Row { get; set; }
	public int SeatId { get; set; }
	public Discount Discount { get; set; }
	public decimal BasePrice { get; set; }
}

public enum Discount
{
	Children = 1,           // Discount: 1.50 (age < 11 + show < 18:00 + dutch spoken movies)
	Students = 2,           // Discount: 1.50 (student pass + only valid on mon-thu)
	Seniors = 3,            // Discount: 1.50 (senior pass + only valid on mon-thu excl. holidays)
	CinemaPass = 4,         // Discount: varies (MaDiWoDo ticket + only valid on mon-thu excl. holidays)
	ThreeD = 5,             // Addition: 2.50 for 3D movies
	None = 0                // Default price: 8.50 or 9.00 if movie runtime > 120
}



