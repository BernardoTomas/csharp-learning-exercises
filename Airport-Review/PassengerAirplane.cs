namespace Airline;


public class PassengerAirplane : Airplane, IPassengerAirplane
{
    private int _passengerCapacity = 0;
    private int _passengerQuantity { get; set; }

    public PassengerAirplane (string Prefix, int PassengerCapacity) : base(Prefix)
    {
        _passengerCapacity = PassengerCapacity;
    }

    public void Load ()
    {
        if(_passengerQuantity == _passengerCapacity) throw new ArgumentException("Atingiu o imite de passageiros!");
        _passengerQuantity += 1;
    }

    public override double CalculateCost()
    {
        return CalculateStandardCost() + 90 * _passengerQuantity;
    }
}