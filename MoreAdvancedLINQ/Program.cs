using Developers.Models;

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
    }
}
