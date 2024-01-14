using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
namespace _net_backend;

// URL -> http://localhost:5097/api/ticket
[ApiController]
[Route("api/[controller]")]
public class TicketController
{
    // Dependency Injection
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTicketAsync([FromBody] Ticket ticket)
    {
        var createdTicket = await _ticketService.CreateTicketAsync(ticket);
        return new OkObjectResult(createdTicket);
    }

    [HttpGet]
    public async Task<IActionResult> GetTickets()
    {
        var allTickets = await _ticketService.GetTicketsAsync();
        return new OkObjectResult(allTickets);
    }

}
