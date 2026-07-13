namespace Students.Models;

public class Student
{
    public string? Name { get; set; }
    public int[] Scores { get; set; } = new int[3];
}