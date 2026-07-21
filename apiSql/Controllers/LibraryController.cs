namespace apiSql.Controllers;
using apiSql.Models;
using apiSql.Repository;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class LibraryController : ControllerBase
{
    private readonly LibraryRepository _repository;

    public LibraryController (LibraryRepository repo)
    {
        _repository = repo;
    }

    [HttpPost]
    public IActionResult AddBook ()
    {
        var book = new Book
        {
            Title = "The Divine Comedy",
            Description = "A journey through the infinite torment of Hell",
            Year = 2013,
            Pages = 811,
            Genre = "Drama",
            Author = new Author
            {
                Name = "Dante Alighieri",
                Email = "mail@mail.com"
            },
            Publisher = new Publisher
            {
                Name = "Paradise Publisher"
            }
        };

        _repository.Add(book);

        return Ok(new { message = "Book added" });
    }
}