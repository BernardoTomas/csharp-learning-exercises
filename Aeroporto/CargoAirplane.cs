namespace Airline;

public class CargoAirplane : Airplane, ICargoAirplane
{
    private double Payload { get; set; }
    private double LoadedWeight { get; set; }

    public CargoAirplane(string Prefix, double Payload) : base(Prefix)
    {
        this.Payload = Payload;
    }

    public void Load(double weight)
    {
        if ((LoadedWeight + weight) > Payload) throw new ArgumentException("Payload achieved");
        LoadedWeight += weight;
    }

    public override double CalculateCost() 
    { 
        return base.CalculateStandardCost() + 35 * LoadedWeight; 
    }
}