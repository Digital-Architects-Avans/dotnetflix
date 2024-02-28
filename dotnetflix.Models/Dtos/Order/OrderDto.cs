using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetflix.Models.Dtos.Order;

public class OrderDto
{
	public int Id { get; set; }
	public decimal TotalPrice { get; set; }
}