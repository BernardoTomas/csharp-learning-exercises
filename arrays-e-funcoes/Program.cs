using System.Dynamic;

class Program
{

    static void Main(string[] args)
    {
        int[,] expensesCost;
        int despesasBrutas = 0;
        int despesasLiquidas = 0;
        
        Console.WriteLine("Entre com o número de despesas: ");
        bool isValidNumberOfExpenses = Int32.TryParse(Console.ReadLine(), out int numberOfExpenses);

        expensesCost = new int[numberOfExpenses, 2];

        for (int i = 0; i < numberOfExpenses; i ++)
        {
            for (int j = 0; j < 2; j ++)
                expensesCost[i, j] = getExpenseCostFromUser();
        }

        for (int i = 0; i < numberOfExpenses; i ++)
        {
            despesasBrutas += expensesCost[i, 0];
            despesasLiquidas += expensesCost[i, 1];
        }

        Console.WriteLine("O total das despesas brutas é: " + despesasBrutas);
        Console.WriteLine("O total das despesas líquidas é: " + despesasLiquidas);
    }

    public static int getExpenseCostFromUser()
    {
        bool isValidExpense= Int32.TryParse(Console.ReadLine(), out int expense);

        if (isValidExpense) return expense;
        else {
            Console.WriteLine("Informe um numero inteiro válido.");
            return getExpenseCostFromUser();
        }
    }
}