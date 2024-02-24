namespace dotnetflix.Api.Data.Entities;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public double Rating { get; set; }

    [Required]
    public int Runtime { get; set; }

    public string Image { get; set; }
}