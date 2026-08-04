using Auth.Models;

namespace Auth.Repository;

public class BookRepository : IBookRepository
{
    protected readonly IUserLoginContext _context;

    public BookRepository (IUserLoginContext context)
    {
        _context = context;
    }
    public IEnumerable<BookDTO> GetBooks()
    {
        return _context.Books.Select(b => new BookDTO
        {
            BookId = b.BookId,
            Title = b.Title,
            Content = b.Content,
            User = b.User
        }).ToList();
    }
    public Book AddBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        
        return book;
    }
    
    public IEnumerable<BookDTO> GetBooksByUserId(int userId)
    {
        return _context.Books
            .Where(b => b.UserId == userId)
            .Select(b => new BookDTO
            {
                BookId = b.BookId,
                Title = b.Title,
                Content = b.Content,
                User = b.User
            }).ToList();
    }
}