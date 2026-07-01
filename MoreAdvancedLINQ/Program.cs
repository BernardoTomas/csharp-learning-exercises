using Developers.Models;
using Students.Models;

public class Program
{
    public static void Main (string[] args)
    {
        List<Developer> developersList = new List<Developer>
        {
            new Developer { Name = "Danilo", Language = "C#" },
            new Developer { Name = "Jonatas", Language = "C#" },
            new Developer { Name = "Kerolainy", Language = "Java" },
            new Developer { Name = "Mateus", Language = "Java" },
            new Developer { Name = "Babi", Language = "Python" },
            new Developer { Name = "Taís", Language = "Python" }    
        };

        var languageListObj = from developer in developersList
                                group developer by developer.Language into languages
                                select languages;

        foreach(var language in languageListObj)
        {
            Console.WriteLine("~~~~~~~~~~~~~ Language ~~~~~~~~~~~~~");
            Console.WriteLine(language.Key);
            Console.WriteLine("~~~~~~~~~~~~~~ Users ~~~~~~~~~~~~~~~");
            foreach(var developer in language)
            {
                Console.WriteLine("Developer: " + developer.Name);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        List<Student> studentsList = new List<Student>
        {
            new Student{ Name = "Laura", Scores = [20, 90, 80] },
            new Student{ Name = "Gustavo", Scores = [70, 60, 80] },
            new Student{ Name = "Tânia", Scores = [50, 60, 40] },
        };

        var passingStudents =
            from student in studentsList
            where student.Scores.Sum() >= 180
            select student;

        Console.WriteLine("^^^^^^^^^^^^^^^^v " + passingStudents.Count() + " Estudantes Passaram v^^^^^^^^^^^^^^^^");
        foreach(var student in passingStudents)
        {
            Console.WriteLine(student.Name + " passou com " + student.Scores.Sum() + " pontos.");
            Console.WriteLine("Maior nota: " + student.Scores.Max());
            Console.WriteLine("Menor nota: " + student.Scores.Min());
            Console.WriteLine("Média: " + (int)student.Scores.Average());
        }

    }
}
