using dotnetflix.Api.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetflix.Api.Entities
{
	public class Seat
	{
		[Required]
		public int Id { get; set; }
    
		[Required]
		public int Number { get; set; }

		[Required]
		public int TheaterRowId { get; set; }
    
		// Navigation property to TheaterRow
		[ForeignKey(nameof(TheaterRowId))]
		public TheaterRow TheaterRow { get; set; }
    
		// Navigation property to Tickets
		public ICollection<Ticket> Tickets { get; set; }
	}
}