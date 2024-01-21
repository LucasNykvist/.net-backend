using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
namespace _net_backend;

// URL -> http://localhost:5097/api/ticket
[ApiController]
[Route("api/[controller]")]
public class TicketController
{
    // Dependency Injection - Constructor Injection (DI) - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0
    private readonly ITicketService _ticketService;

    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTicketAsync([FromBody] Ticket ticket)
    {
        Ticket createdTicket = await _ticketService.CreateTicketAsync(ticket);
        return new OkObjectResult(createdTicket);
    }

    [HttpGet]
    public async Task<IActionResult> GetTickets()
    {
        var _cancellationToken = new CancellationToken();
        Ticket[] allTickets = await _ticketService.GetTicketsAsync(_cancellationToken);
        return new OkObjectResult(allTickets);
    }

    [HttpGet("{title}")]
    public async Task<IActionResult> GetTicketByTitle(string title)
    {
        var _cancellationToken = new CancellationToken();
        Ticket[] allTickets = await _ticketService.GetTicketsAsync(_cancellationToken);
        Ticket ticket = await _ticketService.GetTicketByTitleAsync(title, _cancellationToken);
        return new OkObjectResult(ticket);
    }
    
    [HttpGet("id/{id}")]
    public async Task<IActionResult> GetTicketById(int id){
        var _cancellationToken = new CancellationToken();
        Ticket ticket = await _ticketService.GetTicketByIdAsync(id, _cancellationToken);
        return new OkObjectResult(ticket);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAllTickets()
    {
        await _ticketService.DeleteAllTicketsAsync();
        return new OkObjectResult("All tickets deleted");
    }

}
