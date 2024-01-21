using System.ComponentModel.DataAnnotations;
using Enums;

namespace Models;
public class Ticket
{
    [Key]
    public int Id { get; set; }
    public int TicketNumber { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Assignee { get; set; }
    public TicketEnums.TicketStatus? Status { get; set; }
    public TicketEnums.TicketType? Type { get; set; }
    public TicketEnums.TicketPriority? Priority { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
}