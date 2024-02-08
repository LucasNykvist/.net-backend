using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace _net_backend;
public class BookGenreController : ControllerBase
{
    private readonly BookGenreService _bookGenreService;
    public BookGenreController(BookGenreService bookGenreService)
    {
        _bookGenreService = bookGenreService;
    }

    [HttpPost]
    public IActionResult CreateBookGenre([FromBody] BookGenre bookGenre)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Something went wrong");
            }

            _bookGenreService.CreateBookGenreAsync(bookGenre);
            return Ok("Genre was created");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
