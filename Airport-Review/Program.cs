namespace Airline;

public class MainClass
{
    public static void Main(string[] args)
    {
        Airplane embraer = new Airplane("BLINK-182");
        Flight flight01 = new Flight("001", 2000);
        flight01.Airplane = embraer;

        Console.WriteLine("Aeronave: " + flight01.Airplane.Prefix + flight01.FlightId + "; Distância: " + flight01.Distance + "; Custo: " + flight01.CalculateCost().ToString());
    }
}