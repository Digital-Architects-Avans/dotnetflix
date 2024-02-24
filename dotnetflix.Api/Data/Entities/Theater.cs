using System.ComponentModel.DataAnnotations;

namespace dotnetflix.Api.Data.Entities
{
    public class Theater
    {
        public int Id { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [Required] [Range(1, 500)] public int Seats { get; set; }

        [Required] public string Location { get; set; }
    }

}
