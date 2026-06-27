void ConsoleLogList(List<string> strings)
{
    Console.WriteLine("------------------------------------");
    strings.ForEach(str => Console.WriteLine(strings.IndexOf(str) + " - " + str));
}

List<string> cars = new List<string>(){ "Fusca", "Towner" };

cars.Add("Brasília");

ConsoleLogList(cars);

cars.Remove("Fusca");

ConsoleLogList(cars);

cars.RemoveAt(0);

ConsoleLogList(cars);

cars.Add("Lotus Elise");
cars.Add("Ferrari F1");
cars.Add("Ford Focus");
cars.Add("Fiat Uno com escada");

cars.Sort();

ConsoleLogList(cars);