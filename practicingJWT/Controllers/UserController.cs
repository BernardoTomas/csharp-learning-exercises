namespace Auth.Controllers;

using Auth.DTO;
using Auth.Models;
using Auth.Repository;
using Auth.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;
    private readonly TokenGenerator _tokenGenerator;

    public UserController (IUserRepository repository)
    {
        _repository = repository;
        _tokenGenerator = new TokenGenerator();
    }

    [HttpPost("signup")]
    public IActionResult AddUser([FromBody] User user)
    {
        var userCreated = _repository.AddUser(user);
        if (userCreated is null) return Conflict("User already exists");
        var token = _tokenGenerator.Generate(user);
        return Created("", new { token });
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDTORequest loginReq)
    {
        User? existingUser = _repository.GetUserByEmail(loginReq.Email!);
        if (existingUser == null) return Unauthorized(new { message = "Incorrect email" });
        if (existingUser.Password != loginReq.Password) return Unauthorized(new { message = "Incorrect password" });

        var token = _tokenGenerator.Generate(existingUser);
        return Ok(new { token });
    }

    [HttpGet]
    public IActionResult GetUsernames()
    {
        var userList = _repository.GetUsernames();
        if (userList.Count() == 0) return Ok("No registered users.");
        return Ok(userList);
    }
}