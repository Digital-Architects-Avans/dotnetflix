using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetflix.Api.Entities
{
    public class Ticket
    {
        // TICKET
        [Required]
        public int Id { get; set; }
		
        // MOVIE
        [Required]
		[ForeignKey(nameof(MovieId))]
		public int MovieId { get; set; }
        public string MovieName { get; set; }
		public int MovieRuntime { get; set; }

		// SHOW
		[Required]
		[ForeignKey(nameof(ShowId))]
		public int ShowId { get; set; }
		public DateTime ShowDate { get; set; }
		public DateTime ShowTime { get; set; }
        [Required]
        public float BasePrice { get; set; }
		public Discount Discount { get; set; }

		// THEATER
		[Required]
		[ForeignKey(nameof(TheaterId))]
		public int TheaterId { get; set; }

        // SEAT
        [Required]
		[ForeignKey(nameof(SeatId))]
		public int SeatId { get; set; }
		[Required]
		public int Row { get; set; }
    }
}
