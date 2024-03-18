using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetflix.Api.Data.Entities;

// Junction table for many-to-many relationship
public class TicketSupplement
{
    public int Id { get; set; }
    
    // Composite primary key
    [Key]
    [Column(Order = 1)]
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }

    [Key]
    [Column(Order = 2)]
    public int SupplementId { get; set; }
    public Supplement Supplement { get; set; }
}
