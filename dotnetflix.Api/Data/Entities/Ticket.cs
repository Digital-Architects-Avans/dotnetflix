using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos;

namespace dotnetflix.Api.Data.Entities
{
    public class Ticket
    {
	    public int Id { get; set; }

	    [Required]
	    [ForeignKey(nameof(Show.Id))]
	    public int ShowId { get; set; }
	    
	    public string Movie { get; set; }
	    
	    public string TheaterName { get; set; }
	    
	    public int SeatId { get; set; }
	    
	    public int RowNumber { get; set; }
	    
	    public int SeatNumber { get; set; }
	    
	    public DateTime ShowTime { get; set; }
	    
	    public Discount Discount { get; set; }
	    
	    public decimal TicketPrice { get; set; }
	    
	    // Optional OrderId property for flexibility
	    public int? OrderId { get; set; } // Nullable to allow ticket creation before order assignment
	    
		// Navigation properties
		// The Ticket entity has a many-to-one relationship with the Show entity

		public Show Show { get; set; }
    }
}
