namespace apiSql.Repository;
using Microsoft.EntityFrameworkCore;
using apiSql.Models;

public class LibraryRepository
{
    private readonly LibraryContext _context;

    public LibraryRepository(LibraryContext libContext)
    {
        _context = libContext;
    }

    public List<Book> GetBookList ()
    {
        var query = _context.Books.ToList();

        return query; 
    }

    public Book? GetBookById (int id)
    {
        return _context.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefault(b => b.BookId == id);
    }

    public Book Add(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return book;
    }

    public virtual void Update(Book book)
    {
        _context.Update(book);
        _context.SaveChanges();
    }
}