using dotnetflix.Api.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnetflix.Api.Data.Entities;

public class Order
{
	[Required]
	public int Id { get; set; }
	[Required]
	public decimal TotalPrice { get; set; }
}