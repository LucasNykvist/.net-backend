using Models;
namespace Services;

public interface ITicketService
{
    Task<Ticket> CreateTicketAsync(Ticket ticket);
    Task<Ticket[]> GetTicketsAsync();
    Task<Ticket> GetTicketByTitleAsync(string title);
    Task DeleteAllTicketsAsync();
}
