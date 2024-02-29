using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetflix.Api.Data.Entities;

public class TheaterRow
{
    [Key]
    public int Id { get; set; }
    public int TheaterId { get; set; }
    [ForeignKey("TheaterId")]
    public virtual Theater Theater { get; set; }
    public int RowNumber { get; set; }
    public int NumberOfSeats { get; set; }
}