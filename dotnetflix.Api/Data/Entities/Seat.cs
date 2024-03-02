using dotnetflix.Api.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetflix.Api.Entities
{
	public class Seat
	{
		public int Id { get; set; }
		
		[Required]
		[ForeignKey(nameof(TheaterRow.Id))]
		public int TheaterRowId { get; set; }
    
		[Required]
		public int SeatNumber { get; set; }
		
		public TheaterRow TheaterRow { get; set; }
		
	}
}