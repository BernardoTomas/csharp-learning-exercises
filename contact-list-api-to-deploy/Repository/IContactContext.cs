namespace contact_list_api_to_deploy.Repository;

using contact_list_api_to_deploy.Models;
using Microsoft.EntityFrameworkCore;

public interface IContactContext
{
    public DbSet<Contact> Contacts { get; set; }
    public int SaveChanges();
}