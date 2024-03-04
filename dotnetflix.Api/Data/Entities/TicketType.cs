namespace dotnetflix.Api.Data.Entities;

public class TicketType
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public decimal Discount { get; set; }
}