namespace Models;
public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public BookAuthor Author { get; set; }
    public BookGenre Genre { get; set; }
    public BookPublisher? Publisher { get; set; }
    public DateTime? PublishDate { get; set; }
    public string? Description { get; set; }
    public string? Language { get; set; }
    public int? Pages { get; set; }
}
