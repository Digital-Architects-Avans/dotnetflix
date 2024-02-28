using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetflix.Models.Dtos.Order;

public class GetShowAvailability
{
	public int Show { get; set; }
	public DateTime Date { get; set; }
	public int AvailableSeats { get; set; }
}
