using ProjetoSql;

public class Program
{
    public static void Main(string[] args)
    {
        var context = new StudentContext();

        context.Database.EnsureCreated();
    }
}