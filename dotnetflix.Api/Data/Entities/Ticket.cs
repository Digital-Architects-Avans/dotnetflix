using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Data.Entities
{
    public class Ticket
    {
	    [Required]
	    public int Id { get; set; }
	    
	    [Required]
	    [ForeignKey(nameof(Order.Id))]
	    public int OrderId { get; set; }

	    [Required]
	    [ForeignKey(nameof(Show.Id))]
	    public int ShowId { get; set; }

	    [Required]
	    [ForeignKey(nameof(Seat.Id))]
	    public int SeatId { get; set; }

	    [Required]
	    public DateTime ShowTime { get; set; }
		
		
		// Navigation properties to link to the Seat and Show
		public Seat Seat { get; set; }
		public Show Show { get; set; }
    }
}
