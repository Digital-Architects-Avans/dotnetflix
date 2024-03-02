using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetflix.Api.Entities;

namespace dotnetflix.Api.Data.Entities
{
    public class TheaterRow
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Theater.Id))] 
        public int TheaterId { get; set; }

        public int RowNumber { get; set; }

        public int NumberOfSeats { get; set; }

        public ICollection<Seat> Seats { get; set; }

        public Theater Theater { get; set; }
    }
}