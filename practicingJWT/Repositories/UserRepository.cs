using Auth.DTO;
using Auth.Models;
using Microsoft.EntityFrameworkCore.Update;

namespace Auth.Repository;

public class UserRepository : IUserRepository
{
    protected readonly UserLoginContext _context;

    public UserRepository (UserLoginContext context)
    {
        _context = context;
    }

    public IEnumerable<string?> GetUsernames ()
    {
        return _context.Users.Select(u => u.Name).ToList();
    }

    public User? AddUser (User user)
    {
        var userInDB = _context.Users.FirstOrDefault(u => u.Name == user.Name);

        if (userInDB is not null) return null;

        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }

    public User? GetUserByEmail(string userEmail)
    {
        return _context.Users.FirstOrDefault(u => u.Email == userEmail);
    }
}