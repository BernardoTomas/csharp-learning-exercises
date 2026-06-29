using LINQPractice;

public class Developer
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
}

public class Language
{
    public string Name { get; set; } = "";
}

public class Database
{
    public string Name { get; set; } = "";
}

public class DeveloperLanguage
{
    public Developer ?DeveloperName { get; set; }
    public Language ?LanguageName { get; set; }
}

public class DeveloperDatabase
{
    public Developer ?DeveloperName { get; set; }
    public Database ?DatabaseType { get; set; }
}