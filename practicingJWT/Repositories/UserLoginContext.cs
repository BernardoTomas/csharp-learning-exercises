using Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Repository;

public class UserLoginContext : DbContext, IUserLoginContext
{
    public UserLoginContext(DbContextOptions<UserLoginContext> options) : base(options) {}
    public UserLoginContext() {}

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(b => b.User)
            .WithMany(u => u.Books)
            .HasForeignKey(b => b.UserId);
    }
}