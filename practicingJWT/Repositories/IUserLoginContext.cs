using Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Repository;

public interface IUserLoginContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public int SaveChanges();
}