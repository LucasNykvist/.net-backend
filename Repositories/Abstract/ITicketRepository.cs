namespace Repositories.Abstract;
using Models.DatabaseModels;

public interface ITicketRepository
{
    Task<Ticket> CreateTicketAsync(Ticket ticket);
}
