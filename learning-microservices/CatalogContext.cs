namespace learning_microservices.Repository;

using learning_microservices.Models;
using Microsoft.EntityFrameworkCore;

public class CatalogContext : DbContext
{
    public CatalogContext(DbContextOptions<CatalogContext> options) : base(options) {}
    public DbSet<Product> Products { get; set; }
}