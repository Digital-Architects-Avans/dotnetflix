namespace dotnetflix.Models.Dtos.Email;

public class EmailDto
{
    public string Recipient { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
}