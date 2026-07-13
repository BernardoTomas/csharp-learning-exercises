using LINQPractice;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

List<Artist> artists = new List<Artist> 
{
    new Artist{ Name = "Raul Seixas", Listeners = 50000 },
    new Artist{ Name = "Mozart", Listeners = 15000 },
    new Artist{ Name = "Elvis Presley", Listeners = 25000 },
    new Artist{ Name = "Bob Dylan", Listeners = 30000 },
    new Artist{ Name = "Guns n' Roses", Listeners = 40000 }
};

var topListeners = from artist in artists
                    where artist.Listeners > 30000
                    select artist.Name;

foreach(var artist in topListeners)
{
    Console.WriteLine(artist);
}

string[] words = { "Jeremy", "Samba", "Cocktail", "Tire", "Courage" };

var wordsObj = from word in words
                select new { word, length = word.Length };

foreach(var wordObj in wordsObj)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Word: " + wordObj.word);
    Console.WriteLine("Length: " + wordObj.length);
}

var games = new List<List<string>>
{
    new List<string> { "Age of Empires 2", "Age of Myhtology", "Command and Conquer 3" },
    new List<string> { "Counter Strike", "Call of Duty", "Medal of Honor" },
    new List<string> { "World of Warcraft", "Tibia", "Talisman Online" }
};

var allGames = from gameLine in games
                from game in gameLine
                select game;

foreach(string game in allGames)
{
    Console.WriteLine("-----------------Game-----------------");
    Console.WriteLine(game);
}

List<Author> authors = new List<Author>
{
    new Author { Name = "Jolkein Rolkein Rolkein Tolkein", Id = 1 },
    new Author { Name = "Clive Staples Lewis", Id = 2 },
    new Author { Name = "Caio Fernando Abreu", Id = 3 },
    new Author { Name = "Eduardo Sophr", Id = 4 }
};

List<Book> books = new List<Book>
{
    new Book { Title = "A Batalha do Apocalipse", AuthorId = 4 },
    new Book { Title = "The Chronicles of Narnia", AuthorId = 2 },
    new Book { Title = "Morangos Mofados", AuthorId = 3 },
    new Book { Title = "The adventures of Tom Bombadil", AuthorId = 1 }    
};

var BooksByAuthor = from author in authors
                    from book in books
                        where author.Id == book.AuthorId
                    select new LibraryDTO{ AuthorName = author.Name, BookTitle = book.Title };

foreach(LibraryDTO book in BooksByAuthor)
{
    Console.WriteLine(">>>>>>>>>>>>>>>>>>>> Library Entry <<<<<<<<<<<<<<<<<<<<<");
    Console.WriteLine("Book title: " + book.BookTitle);
    Console.WriteLine("By author: " + book.AuthorName);
}

int[] numbersToOrder = { 1, 12, 6, 30 };

var orderedNumbers = from number in numbersToOrder
                        orderby number
                        select number;

foreach(int number in orderedNumbers)
{
    Console.WriteLine(number);
}

Developer Gerson = new Developer { FirstName = "Gerson", LastName = "Rodrigues" };
Developer Julia = new Developer { FirstName = "Júlia", LastName = "Tavares" };
Developer Susana = new Developer { FirstName = "Susana", LastName = "Pinto" };
Developer Silvio = new Developer { FirstName = "Silvio", LastName = "Silva" };
Developer Sebastiao = new Developer { FirstName = "Sebastião", LastName = "Magalhães" };
Developer Carol = new Developer { FirstName = "Carol", LastName = "Lima" };
Developer Vanessa = new Developer { FirstName = "Vanessa", LastName = "Santos" };
Developer Jeremias = new Developer { FirstName = "Gerson", LastName = "Barra" };

Language CSharp = new Language { Name = "C#" };
Language Java = new Language { Name = "Java" };
Language Python = new Language { Name = "Python" };

Database MySql = new Database { Name = "MySQL" };
Database SqlServer = new Database { Name = "SQL Server" };

List<DeveloperLanguage> developerLanguages = new List<DeveloperLanguage>
{
    new DeveloperLanguage { DeveloperName = Julia, LanguageName = CSharp },
    new DeveloperLanguage { DeveloperName = Sebastiao, LanguageName = CSharp },
    new DeveloperLanguage { DeveloperName = Gerson, LanguageName = CSharp },
    new DeveloperLanguage { DeveloperName = Vanessa, LanguageName = Java },
    new DeveloperLanguage { DeveloperName = Carol, LanguageName = Java },
    new DeveloperLanguage { DeveloperName = Silvio, LanguageName = Java },
    new DeveloperLanguage { DeveloperName = Jeremias, LanguageName = Python },
    new DeveloperLanguage { DeveloperName = Susana, LanguageName = Python },
};

List<DeveloperDatabase> developerDatabases = new List<DeveloperDatabase>
{
    new DeveloperDatabase { DeveloperName = Julia, DatabaseType = MySql },
    new DeveloperDatabase { DeveloperName = Sebastiao, DatabaseType = MySql },
    new DeveloperDatabase { DeveloperName = Gerson, DatabaseType = SqlServer },
    new DeveloperDatabase { DeveloperName = Vanessa, DatabaseType = SqlServer },
    new DeveloperDatabase { DeveloperName = Carol, DatabaseType = SqlServer },
    new DeveloperDatabase { DeveloperName = Silvio, DatabaseType = MySql },
    new DeveloperDatabase { DeveloperName = Jeremias, DatabaseType = MySql },
    new DeveloperDatabase { DeveloperName = Susana, DatabaseType = MySql },
};

var devSkills = from developerLanguage in developerLanguages
                join developerDatabase in developerDatabases
                on developerLanguage.DeveloperName equals developerDatabase.DeveloperName
                select new {
                    DeveloperName = developerLanguage.DeveloperName!.FirstName + " " + developerLanguage.DeveloperName.LastName,
                    Language = developerLanguage.LanguageName!.Name,
                    Database = developerDatabase.DatabaseType!.Name
                };

foreach(var devSkill in devSkills)
{
    Console.WriteLine("|||||||||||||||||||> Developer Info <|||||||||||||||||||");
    Console.WriteLine("Full name: " + devSkill.DeveloperName);
    Console.WriteLine("Stacks: " + devSkill.Language + ", " + devSkill.Database);
}