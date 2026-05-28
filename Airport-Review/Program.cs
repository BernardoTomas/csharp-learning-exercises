namespace Airline;

public class MainClass
{
    public static void Main(string[] args)
    {
        Airplane embraer = new PassengerAirplane("SUM-41", 4);
        Airplane tam = new CargoAirplane("BLINK-182", 400);

        Flight flight01 = new Flight("001", 2000);
        Flight flight02 = new Flight("002", 1000);
        
        flight01.Airplane = embraer;
        flight02.Airplane = tam;
    }
}