namespace contact_list_api_to_deploy.Models;
using System.ComponentModel.DataAnnotations;
public class Contact
{
    [Key]
    public int ContactId { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}