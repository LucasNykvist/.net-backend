using Models;
using Repositories.Abstract;

namespace Repositories.Concrete;
public class TicketRepository : ITicketRepository
{
    public Task<Ticket> CreateTicketAsync(Ticket ticket)
    {
        throw new NotImplementedException();
    }
}
