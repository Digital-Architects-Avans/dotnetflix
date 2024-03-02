using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetflix.Models.Dtos.Show;

namespace dotnetflix.Api.Data.Entities
{
    public class Show
    {
        public int Id { get; set; }
    
        [Required]
        [ForeignKey(nameof(Movie.Id))]
        public int MovieId { get; set; }
        
        [Required]
        [ForeignKey(nameof(Theater.Id))]
        public int TheaterId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int ScreenTime { get; set; }

        [Required]
        public MovieType Type { get; set; }
        
        [Required]
        public decimal BasePrice { get; set; }
        
        // Navigation properties
        // The Show entity has a one-to-many relationship with the Ticket entity
        // The Show entity has a many-to-one relationship with the Movie entity
        public Movie Movie { get; set; }
        
        public Theater Theater { get; set; }
        
        public ICollection<Ticket> Tickets { get; set; }
    }
    
}