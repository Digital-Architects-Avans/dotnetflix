using System.ComponentModel.DataAnnotations;

namespace dotnetflix.Api.Data.Entities
{
    public class Theater
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        // This property might still be useful for quick access to the total seat count 
        [Required]
        [Range(1, 500)]
        public int Seats { get; set; }
        
        public ICollection<TheaterRow> TheaterRows { get; set; }
        public ICollection<Show> Shows { get; set; }
    }

}
