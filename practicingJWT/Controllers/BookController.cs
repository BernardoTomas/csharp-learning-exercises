namespace Auth.Controllers;

using Auth.DTO;
using Auth.Models;
using Auth.Repository;
using Auth.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

[ApiController]
[Route("[controller]")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class BookController : ControllerBase
{
    private readonly IBookRepository _repository;

    public BookController (IBookRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    [Authorize(Policy = "RequireAdminAccess")]
    public IActionResult AddBook(Book book)
    {
        _repository.AddBook(book);

        return Created("", book);
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult GetAllBooks()
    {
        var allBooks = _repository.GetBooks();
        if (allBooks.Count() == 0) return Ok("No books registered");
        else return Ok(allBooks);
    }

    [HttpGet("{userId}")]
    [Authorize(Roles = "admin,user")]
    public IActionResult GetBooksByUserId (int userId)
    {
        var booksList = _repository.GetBooksByUserId(userId);
        if (booksList.Count() == 0) return Ok("User has no books registered");
        else return Ok(booksList);
    }
}