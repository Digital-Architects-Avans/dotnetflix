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
        AL = 1,
        Six = 6,
        Nine = 9,
        Twelve = 12,
        Sixteen = 16,
        Eighteen = 18,
        NA = 0
    }
}