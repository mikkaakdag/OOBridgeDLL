namespace OOBridgeDLL;

public class Car : Vehicle
{
    public Car(string licensePlate, DateTime date, bool hasBrobizz)
        : base(licensePlate, date, hasBrobizz)
    {

    }

    public override double Price()   
    {
        return 230;
    }

    public override string VehicleType()
    {
        return "Car";
    }
    public override double Brobizz()
    {
        if (HasBrobizz == true)
        {
            return Price() * 0.9;
        }
        else
        {
            return Price();
        }
    }
}
