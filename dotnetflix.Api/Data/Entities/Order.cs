using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetflix.Api.Data.Entities;

public class Order
{
    [Required]
    public int Id { get; set; }
    
    // Add this property if you have a Customer/User entity during later sprints
    // [ForeignKey(nameof(Customer.Id))]
    // public int CustomerId { get; set; }
    
    // Navigation property to Customer/User
    // public Customer Customer { get; set; }

    // Navigation property to Tickets
    public ICollection<Ticket> Tickets { get; set; }
}