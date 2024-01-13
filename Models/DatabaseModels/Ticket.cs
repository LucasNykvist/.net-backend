namespace Models;
public class Ticket
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public string? Priority { get; set; }
    public string? Project { get; set; }
    public string? Assignee { get; set; }
    public string? Reporter { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
