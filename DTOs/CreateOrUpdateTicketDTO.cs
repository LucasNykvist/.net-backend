namespace DTOs;

// Data som ska skickas till backend från frontend
public class CreateOrUpdateTicketDTO
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public string? Priority { get; set; }
    public string? Assignee { get; set; }
}
