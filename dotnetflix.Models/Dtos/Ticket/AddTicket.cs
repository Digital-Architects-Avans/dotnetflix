using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetflix.Models.Dtos.Show;

namespace dotnetflix.Models.Dtos.Ticket;

public class AddTicket
{
	public int Id { get; set; }
	public int ShowId { get; set; }
	public int OrderId { get; set; }
	public int Row { get; set; }
	public int SeatId { get; set; }
	public Discount Discount { get; set; }
	public decimal BasePrice { get; set; }
}
