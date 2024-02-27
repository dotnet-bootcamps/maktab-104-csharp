namespace S05_OOP.Codes.Vehicle;

internal class Bicycle : VehicleBase
{
    public override void IncreaseSpeed(int kph)
    {
    }

    public override void IncreaseSpeed(int kph, int minSpeed)
    {
        throw new NotImplementedException();
    }

    public override void DecreaseSpeed(int kph)
    {
    }

    public override void Brake()
    {
    }
}