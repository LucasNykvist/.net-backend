using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;
public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }
    public DbSet<Ticket> Tickets { get; set; }
}
