namespace Repositories.Abstract;
using Models;

public interface ITicketRepository
{
    Task<Ticket> CreateTicketAsync(Ticket ticket);

    Task<Ticket[]> GetTicketsAsync(CancellationToken ct);

    Task<Ticket> GetTicketByTitleAsync(string title, CancellationToken ct);

    Task<Ticket> GetTicketByIdAsync(int id, CancellationToken ct);

    Task DeleteByIdAsync(int id);

    Task DeleteAllTicketsAsync();
}
