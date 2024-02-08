﻿namespace Models;
public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }
    public string? Publisher { get; set; }
    public DateTime? PublishDate { get; set; }
    public string? Description { get; set; }
    public string? ISBN { get; set; }
    public string? Language { get; set; }
    public int? Pages { get; set; }
}
