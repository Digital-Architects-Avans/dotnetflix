using System.ComponentModel.DataAnnotations;

namespace dotnetflix.Api.Data.Entities;

public class Review
{
    public int Id { get; set; }
    [StringLength(100)]
    public string Name { get; set; }
    [Range (1, 5)]
    public int Stars { get; set; }
    [StringLength(500)]
    public string ReviewText { get; set; }
}