using Models;

namespace Repositories;
public interface IBookGenreRepository
{
    void CreateBookGenreAsync(BookGenre bookGenre);
}
