namespace dotnetflix.Models.Dtos.Review;

public class ReviewDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stars { get; set; }
    public string ReviewText { get; set; }
}