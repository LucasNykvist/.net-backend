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

    public Task<Ticket> GetTicketByIdAsync(int id, CancellationToken ct)
    {
        return _ticketRepository.GetTicketByIdAsync(id, ct);
    }

    public Task<Ticket> GetTicketByTitleAsync(string title, CancellationToken ct)
    {
        return _ticketRepository.GetTicketByTitleAsync(title, ct);
    }

    public Task<Ticket[]> GetTicketsAsync(CancellationToken ct)
    {
        return _ticketRepository.GetTicketsAsync(ct);
    }
}
