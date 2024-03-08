using System.ComponentModel.DataAnnotations;

namespace dotnetflix.Api.Data.Entities;

public class Order
{
    public int Id { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public string Uuid { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    // Add this property if we have a Customer/User entity during later sprints
    // [ForeignKey(nameof(Customer.Id))]
    // public int CustomerId { get; set; }
    
    // Navigation property to Customer/User
    // public Customer Customer { get; set; }

    // Navigation property to Tickets
    // The Order entity has a one-to-many relationship with the Ticket entity
    public ICollection<Ticket> Tickets { get; set; }
}