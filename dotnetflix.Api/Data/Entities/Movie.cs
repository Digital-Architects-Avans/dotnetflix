using System.ComponentModel.DataAnnotations;

namespace dotnetflix.Api.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2100)]
        public int Year { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public Rating Rating { get; set; }

        [Required]
        [Range(1, 500)]
        public int Runtime { get; set; }

        public string Image { get; set; }
    }

    public enum Rating
    {
        G = 1,      // General audiences – All ages admitted
        PG = 2,     // Parental guidance suggested – Some material may not be suitable for children
        PG13 = 3,   // Parents strongly cautioned – Some material may be inappropriate for children under 13
        R = 4,      // Restricted – Under 17 requires accompanying parent or adult guardian
        NC17 = 5,   // No one 17 and under admitted
        NA = 0      // Not Available/Not Applicable
    }
}