using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Abstract;

namespace Repositories.Concrete;
public class TicketRepository : ITicketRepository
{
    // Dependency Injection
    private readonly MyContext _context;

    public TicketRepository(MyContext context)
    {
        _context = context;
    }
    public async Task<Ticket> CreateTicketAsync(Ticket ticket)
    {
        await _context.Tickets.AddAsync(ticket);
        await _context.SaveChangesAsync();
        return ticket;
    }

    public async Task DeleteAllTicketsAsync()
    {
        await _context.Database.ExecuteSqlRawAsync("DELETE FROM Tickets");
    }

    public async Task<Ticket[]> GetTicketsAsync()
    {
        return await _context.Tickets.ToArrayAsync();
    }
}
