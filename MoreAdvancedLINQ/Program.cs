using Developers.Models;
using Streaming.Models;
using Students.Models;

public class Program
{
    public static void Main (string[] args)
    {
        // List<Developer> developersList = new List<Developer>
        // {
        //     new Developer { Name = "Danilo", Language = "C#" },
        //     new Developer { Name = "Jonatas", Language = "C#" },
        //     new Developer { Name = "Kerolainy", Language = "Java" },
        //     new Developer { Name = "Mateus", Language = "Java" },
        //     new Developer { Name = "Babi", Language = "Python" },
        //     new Developer { Name = "Taís", Language = "Python" }    
        // };

        // var languageListObj = from developer in developersList
        //                         group developer by developer.Language into languages
        //                         select languages;

        // foreach(var language in languageListObj)
        // {
        //     Console.WriteLine("~~~~~~~~~~~~~ Language ~~~~~~~~~~~~~");
        //     Console.WriteLine(language.Key);
        //     Console.WriteLine("~~~~~~~~~~~~~~ Users ~~~~~~~~~~~~~~~");
        //     foreach(var developer in language)
        //     {
        //         Console.WriteLine("Developer: " + developer.Name);
        //     }
        //     Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        // }

        // List<Student> studentsList = new List<Student>
        // {
        //     new Student{ Name = "Laura", Scores = [20, 90, 80] },
        //     new Student{ Name = "Gustavo", Scores = [70, 60, 80] },
        //     new Student{ Name = "Tânia", Scores = [50, 60, 40] },
        // };

        // var passingStudents =
        //     from student in studentsList
        //     where student.Scores.Sum() >= 180
        //     select student;

        // Console.WriteLine("^^^^^^^^^^^^^^^^v " + passingStudents.Count() + " Estudantes Passaram v^^^^^^^^^^^^^^^^");
        // foreach(var student in passingStudents)
        // {
        //     Console.WriteLine(student.Name + " passou com " + student.Scores.Sum() + " pontos.");
        //     Console.WriteLine("Maior nota: " + student.Scores.Max());
        //     Console.WriteLine("Menor nota: " + student.Scores.Min());
        //     Console.WriteLine("Média: " + (int)student.Scores.Average());
        // }

        List<Media> newMedia = new List<Media>
        {
            new Movie("The Fellowship of the Ring", [2, 3], new TimeSpan(3, 30, 0)),
            new Movie("The Two Towers", [2, 3], new TimeSpan(4, 0, 0)),
            new Movie("The Return of the King", [2, 3], new TimeSpan(4, 30, 0)),
            new Movie("The Princess Bride", [0, 3], new TimeSpan(1, 30, 0)),
            new TvShow("Arcane", [3, 4], "arcane"),
            new Episode("Welcome to the Playground", "arcane", 1, 1, new TimeSpan(0, 50, 0)),
            new Episode("Some Mysteries Are Better Left Unsolved", "arcane", 1, 2, new TimeSpan(0, 46, 0)),
            new Episode("The Base Violence Necessary for Change", "arcane", 1, 3, new TimeSpan(0, 54, 0)),
        };

        StreamingDBModel StreamingDB = new StreamingDBModel();

        foreach(Media mediaItem in newMedia)
        {
            StreamingDB.AddMedia(mediaItem);
        }

        var AdventureMovies = StreamingDB.GetMediaByGenre((int)MediaGenres.Adventure);

        Console.WriteLine("---------- Filmes de Aventura ----------");
        foreach (var movie in AdventureMovies)
        {
            Console.WriteLine(movie.Name);
        }
    }
}
