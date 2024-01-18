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
        try
        {
            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

    }

    public async Task DeleteAllTicketsAsync()
    {
        try
        {
            await _context.Database.ExecuteSqlRawAsync("DELETE FROM Tickets");
        }
        catch (Exception e)
        {
            
            throw new Exception(e.Message);
        }
    }

    public async Task DeleteByIdAsync(int id)
    {

        try
        {
            var foundTicket =  await GetTicketByIdAsync(id);
            _context.Tickets.Remove(foundTicket);
        }
        catch (Exception e)
        {
            
            throw new Exception(e.Message);
        }


    }

    public async Task<Ticket> GetTicketByIdAsync(int id)
    {
        try
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
        catch (ArgumentException e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<Ticket> GetTicketByTitleAsync(string title)
    {
        try
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
        catch (ArgumentException e)
        {
            
            throw new Exception(e.Message);
        }
    }
    public async Task<Ticket[]> GetTicketsAsync()
    {
        try
        {
            return await _context.Tickets.ToArrayAsync();
        }
        catch (ArgumentNullException e)
        {
            throw new Exception(e.Message, e.InnerException);
        }
        
    }
}
