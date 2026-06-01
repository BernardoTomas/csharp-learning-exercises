namespace Airline;

public class Flight
{
    public string FlightId { get; set; }
    public double Distance { get; set; }

    private FlightType? _FlightType { get; set; }
    private IAirplane? _Airplane { get; set; }
    public IAirplane? Airplane { 
        get { return _Airplane; } 
        set
        {
            if (value!.GetType() == typeof(PassengerAirplane))
            {
                _FlightType = FlightType.Commercial;
            } 
            else
            {
                _FlightType = FlightType.Cargo;                
            }
            _Airplane = value;
        } 
    }

    public Flight (string FlightId, double Distance)
    {
        this.FlightId = FlightId;
        this.Distance = Distance;
    }

    public void Load()
    {
        if (_Airplane is null) throw new InvalidDataException("Airplane not defined");
        if (_FlightType == FlightType.Cargo) throw new ArgumentException("Cargo flights must specify a weight");
        IPassengerAirplane currentAirplane = (IPassengerAirplane)_Airplane;
        currentAirplane.Load();
    }

    public void Load(double weight)
    {
        if (_Airplane is null) throw new InvalidDataException("Airplane not defined");
        if (_FlightType == FlightType.Commercial) throw new ArgumentException("Commercial flights must not specify a weight");
        ICargoAirplane currentAirplane = (ICargoAirplane)_Airplane;
        currentAirplane.Load(weight);
    }

    public double CalculateCost ()
    {
        if (_Airplane is null) throw new InvalidDataException("Airplane not defined");
        return _Airplane.CalculateCost() + Distance * 20;
    }
}