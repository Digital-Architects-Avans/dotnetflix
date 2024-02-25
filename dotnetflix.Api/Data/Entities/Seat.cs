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
