using Auth.Models;

namespace Auth.Repository;

public interface IBookRepository
{
    IEnumerable<BookDTO> GetBooks();
    Book? AddBook(Book book);
    IEnumerable<BookDTO> GetBooksByUserId(int userId);
}