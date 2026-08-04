namespace Auth.Models;

public class BookDTO
{   
    public int BookId { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public User? User { get; set; }
}