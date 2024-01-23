using Microsoft.Extensions.Logging;
using Models;
using Repositories.Abstract;

namespace Services;
public class TicketService : ITicketService
{
    // Dependency Injection
    private readonly ITicketRepository _ticketRepository;
    private readonly ILogger<TicketService> _logger;

    public TicketService(ITicketRepository ticketRepository, ILogger<TicketService> logger)
    {
        _ticketRepository = ticketRepository;
        _logger = logger;
    }
    public Task<Ticket> CreateTicketAsync(Ticket ticket)
    {
        return _ticketRepository.CreateTicketAsync(ticket) ?? throw new Exception("Ticket not created");
    }

    public Task DeleteAllTicketsAsync()
    {
        return _ticketRepository.DeleteAllTicketsAsync();
    }

    public async Task<Ticket> GetTicketByIdAsync(int id, CancellationToken ct)
    {
        try
        {
            return await _ticketRepository.GetTicketByIdAsync(id, ct) ?? throw new Exception("Ticket with that id not found");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred when getting ticket by id");
            throw;
        }
    }

    public async Task<Ticket> GetTicketByTitleAsync(string title, CancellationToken ct)
    {
        try
        {
            return await _ticketRepository.GetTicketByTitleAsync(title, ct) ?? throw new Exception("Ticket with that title not found");
        }
        catch (Exception)
        {
            _logger.LogError("An error occurred when getting ticket by title");
            throw;
        }
    }

    public async Task<Ticket[]> GetTicketsAsync(CancellationToken ct)
    {
        try
        {
            return await _ticketRepository.GetTicketsAsync(ct) ?? throw new Exception("No tickets found");
        }
        catch (Exception)
        {
            _logger.LogError("An error occurred when getting tickets");
            throw;
        }
    }
}
