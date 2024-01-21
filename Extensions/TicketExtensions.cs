using Models;
using DTOs;
using static Enums.TicketEnums;

namespace Extensions;
public static class TicketExtensions
{
    public static Ticket ToDTO(this CreateOrUpdateTicketDTO ticket)
    {
        return new Ticket
        {
            Title = ticket.Title,
            Description = ticket.Description,
            Status = Enum.Parse<TicketStatus>(ticket.Status),
            Type = Enum.Parse<TicketType>(ticket.Type),
            Priority = Enum.Parse<TicketPriority>(ticket.Priority),
            Assignee = ticket.Assignee,
            CreatedAt = DateTime.Now,
            UpdatedAt = null,
            ClosedAt = null
        };
    }

    public static CreateOrUpdateTicketDTO ToModel (this Ticket ticket)
    {
        return new CreateOrUpdateTicketDTO
        {
            Title = ticket.Title,
            Description = ticket.Description,
            Status = ticket.Status.ToString(),
            Type = ticket.Type.ToString(),
            Priority = ticket.Priority.ToString(),
            Assignee = ticket.Assignee
        };
    }
}
