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

    public async Task DeleteByIdAsync(int id)
    {
        var foundTicket =  await GetTicketByIdAsync(id);
        _context.Tickets.Remove(foundTicket);
    }

    public async Task<Ticket> GetTicketByIdAsync(int id)
    {
        Ticket? ticket = await _context.Tickets.FirstOrDefaultAsync(ticket => ticket.Id == id);

        if(ticket == null)
        {
            throw new Exception("Ticket not found");
        } else
        {
            return ticket;
        }
    }

    public async Task<Ticket> GetTicketByTitleAsync(string title)
    {
        Ticket? ticket = await _context.Tickets.FirstOrDefaultAsync(ticket => ticket.Title == title);
        
        if(ticket == null)
        {
            throw new Exception("Ticket not found");
        } else
        {
            return ticket;
        }
    }

    public async Task<Ticket[]> GetTicketsAsync()
    {
        return await _context.Tickets.ToArrayAsync();
    }
}
