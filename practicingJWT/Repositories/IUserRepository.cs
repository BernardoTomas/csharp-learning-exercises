using Auth.Models;

namespace Auth.Repository;

public interface IUserRepository
{
    IEnumerable<string?> GetUsernames();
    User? AddUser(User user);
}