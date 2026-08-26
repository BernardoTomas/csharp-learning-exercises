namespace contact_list_api_to_deploy.Repository;

using contact_list_api_to_deploy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class ContactContext : DbContext, IContactContext
{
    public DbSet<Contact> Contacts { get; set; } = null!;
    public ContactContext() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=localhost;Database=ContactList;User=SA;Password=TrybeContact!;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}