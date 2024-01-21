﻿using System.ComponentModel.DataAnnotations;

namespace Models;
public class Ticket
{
    [Key]
    public int Id { get; set; }
    public int TicketNumber { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public string? Priority { get; set; }
    public string? Assignee { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
}

