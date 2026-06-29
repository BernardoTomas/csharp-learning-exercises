using System.Reflection.Metadata.Ecma335;
using LINQPractice;

public class Author
{
    public string Name { get; set; } = "";
    public int Id { get; set; }
}

public class Book
{
    public string Title { get; set; } = "";
    public int AuthorId { get; set; }
}

public class LibraryDTO
{
    public string AuthorName { get; set; } = "";
    public string BookTitle { get; set; } = "";
}