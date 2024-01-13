using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;
public class AppContext
{
    public DbSet<Ticket> Tickets { get; set; }
}
