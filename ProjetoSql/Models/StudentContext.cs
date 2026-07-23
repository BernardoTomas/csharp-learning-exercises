using Microsoft.EntityFrameworkCore;
namespace ProjetoSql;

public class StudentContext : DbContext
{
    public StudentContext(DbContextOptions<StudentContext> options) : base (options) {}
    
    public StudentContext() {}

    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("DOTNET_CONNECTION_STRING");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}