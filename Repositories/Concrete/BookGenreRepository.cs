using Microsoft.Extensions.Logging;
using Models;

namespace Repositories;
public class BookGenreRepository : IBookGenreRepository
{
    private readonly MyContext _context;
    private readonly ILogger<BookGenreRepository> _logger;
    public BookGenreRepository(MyContext context, ILogger<BookGenreRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async void CreateBookGenreAsync(BookGenre bookGenre)
    {
        try
        {
            var addedGenre = await _context.Genres.AddAsync(bookGenre) ?? throw new Exception("BookGenre not added to database");
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            _logger.LogError($"BookGenreRepository.CreateBookGenreAsync: {e.Message}");
        }
    }
}
