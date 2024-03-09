using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetflix.Models.Dtos.Order;

public class AddOrderDto
{
	public ICollection<int> TicketIds { get; set; }
	
	public string Uuid { get; set; }
	public string CustomerName { get; set; }
	public string CustomerEmail { get; set; }
	
}
