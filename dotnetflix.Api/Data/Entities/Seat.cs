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
		public int Row {  get; set; }
		
		[Required]
		[ForeignKey(nameof(Theater.Id))]
		public int TheaterId { get; set; }
	}
}

/* 
 * De bioscoop bestaat uit 6 zalen: 3 grote zalen (1 tot en met 3) en 3 kleine (4 tot en met 6).
 *    - Zaal 1 tot en met 3 hebben elk 8 rijen van 15 stoelen.
 *    - Zaal 4 is een kleine(re) zaal en heeft 60 stoelen in 6 rijen van 10.
 *    - Zaal 5 en 6 zijn de kleine zalen met allebei 50 stoelen, voorin 2 maal 10 stoelen, achterin 2 maal 15 stoelen
 */