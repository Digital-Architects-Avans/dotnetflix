using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetflix.Models.Dtos.Ticket;

public class UpdateTicketDto
{
    public int ShowId { get; set; }
    public int SeatId { get; set; }
    public int TicketTypeId { get; set; }
    public decimal TicketPrice { get; set; }
}
