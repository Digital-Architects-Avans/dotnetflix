using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetflix.Models.Dtos.Order;

public class UpdateOrderDto
{
	public ICollection<int> TicketIds { get; set; }
}
