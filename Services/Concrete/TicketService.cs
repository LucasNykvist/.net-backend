using Models;
using Repositories.Abstract;

namespace Services;
public class TicketService : ITicketService
{
    // Dependency Injection
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }
    public Task<Ticket> CreateTicketAsync(Ticket ticket)
    {
        return _ticketRepository.CreateTicketAsync(ticket);
    }
}
