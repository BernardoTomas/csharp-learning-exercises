using Person;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person.Person("Gerson", 89);

        Console.WriteLine(person1.Name);

        person1.Name = "Sérgio";

        Console.WriteLine(person1.Name);
    }
}