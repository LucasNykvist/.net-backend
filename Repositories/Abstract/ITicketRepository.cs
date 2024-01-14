namespace Repositories.Abstract;
using Models;

public interface ITicketRepository
{
    Task<Ticket> CreateTicketAsync(Ticket ticket);

    Task<Ticket[]> GetTicketsAsync();

    Task<Ticket> GetTicketByTitleAsync(string title);

    Task<Ticket> GetTicketByIdAsync(int id);

    Task DeleteAllTicketsAsync();
}
