using Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Repository;

public class UserLoginContext : DbContext
{
    public UserLoginContext(DbContextOptions<UserLoginContext> options) : base(options) {}
    public UserLoginContext() {}

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}