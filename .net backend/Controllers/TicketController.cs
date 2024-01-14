using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
namespace _net_backend;

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
        return new CreatedAtRouteResult("GetTicketById", new { id = createdTicket.Id }, createdTicket);
    }

}
