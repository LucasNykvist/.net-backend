using Models;
namespace Services;

public interface ITicketService
{
    Task<Ticket> CreateTicketAsync(Ticket ticket);
    Task<Ticket[]> GetTicketsAsync(CancellationToken ct);
    Task<Ticket> GetTicketByTitleAsync(string title, CancellationToken ct);
    Task<Ticket> GetTicketByIdAsync(int id, CancellationToken ct);
    Task DeleteAllTicketsAsync();
}
