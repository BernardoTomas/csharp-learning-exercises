namespace Person;

class Person
{
    private string _name;
    // private int _age;

    public string Name { 
        get { return _name; }
        set { _name = value; }
    }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}