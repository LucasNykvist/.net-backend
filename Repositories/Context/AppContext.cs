using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;
public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> Authors { get; set; }
    public DbSet<BookGenre> Genres { get; set; }
    public DbSet<BookPublisher> Publishers { get; set; }
}
