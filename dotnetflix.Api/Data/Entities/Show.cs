using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public TimeSpan Time { get; set; }

        [Required]
        public MovieType Type { get; set; }

        [Required]
        public decimal BasePrice { get; set; }
    }

    public enum MovieType
    {
        Regular,
        ThreeD,
    }
}