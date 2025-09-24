namespace OOBridgeDLL;

public class Car : Vehicle
{
    public Car(string licensePlate, DateTime date, bool hasBrobizz)
        : base(licensePlate, date, hasBrobizz)
    {

    }

    protected override double GetBasePrice()   
    {
        return 230;
    }

    public override string VehicleType()
    {
        return "Car";
    }
}
