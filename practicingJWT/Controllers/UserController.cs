namespace Auth.Controllers;

using Auth.DTO;
using Auth.Models;
using Auth.Repository;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("{controller}")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;
    private LoginDTORequest _loginRequest { get; set; }

    public UserController (IUserRepository repository)
    {
        _repository = repository;
    }

    public string Login(LoginDTORequest loginReq)
    {
        _loginRequest = loginReq;
        return "yeet";
    }

    [HttpGet]
    public IActionResult GetUsernames()
    {
        var userList = _repository.GetUsernames();
        if (userList.Count() == 0) return Ok("No registered users.");
        return Ok(userList);
    }

    [HttpPost]
    public IActionResult AddUser([FromBody] User user)
    {
        var createdUser = _repository.AddUser(user);
        
        if (createdUser is null) return Conflict("User already exists");
        else return Created("", createdUser);
    }
}