using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base (options) {}
    public LibraryContext() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}