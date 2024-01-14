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

    public Task DeleteAllTicketsAsync()
    {
        return _ticketRepository.DeleteAllTicketsAsync();
    }

    public Task<Ticket> GetTicketByTitleAsync(string title)
    {
        return _ticketRepository.GetTicketByTitleAsync(title);
    }

    public Task<Ticket[]> GetTicketsAsync()
    {
        return _ticketRepository.GetTicketsAsync();
    }
}
