using Models;
using Repositories;

namespace Services;
public class BookGenreService
{
    private readonly IBookGenreRepository _bookGenreRepository;
    public BookGenreService(BookGenreRepository bookGenreRepository)
    {
        _bookGenreRepository = bookGenreRepository;
    }

    public void CreateBookGenreAsync(BookGenre bookGenre)
    {
        try
        {
            _bookGenreRepository.CreateBookGenreAsync(bookGenre);
        }
        catch (Exception)
        {
            // xd
            throw;
        }

    }
}
