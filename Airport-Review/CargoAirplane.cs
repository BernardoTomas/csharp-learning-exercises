namespace Airline;

public class CargoAirplane : Airplane, ICargoAirplane
{
    private double _payLoad { get; set; }
    private double _loadedWeight { get; set; }

    public CargoAirplane(string Prefix, double PayLoad) : base(Prefix)
    {
        _payLoad = PayLoad;
    }

    public void Load (double weight)
    {
        if ((_loadedWeight + weight) > _payLoad) throw new ArgumentException("Limite de carga excedida!");
        _loadedWeight += weight;
    }

    public override double CalculateCost()
    {
        return CalculateStandardCost() * 1.3 + _loadedWeight * 35;
    }
}