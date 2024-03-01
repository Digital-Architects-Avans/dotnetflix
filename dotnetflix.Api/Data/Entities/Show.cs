using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dotnetflix.Models.Dtos.Show;

namespace dotnetflix.Api.Data.Entities
{
    public class Show
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required]
        [ForeignKey("Theater")]
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int ScreenTime { get; set; }

        [Required]
        public MovieType Type { get; set; }

    }    
}