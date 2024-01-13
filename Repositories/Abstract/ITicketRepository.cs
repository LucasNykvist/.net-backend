namespace Repositories.Abstract;
using Models;



public interface ITicketRepository
{
    Task<Ticket> CreateTicketAsync(Ticket ticket);
}
