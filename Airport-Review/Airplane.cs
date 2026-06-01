namespace Airline;

public abstract class Airplane : IAirplane
{
    public string Prefix { get; set; }

    public Airplane (string Prefix)
    {
        this.Prefix = Prefix;
    }

    protected double CalculateStandardCost()
    {
        return 1352.45;
    }
    public abstract double CalculateCost();
}