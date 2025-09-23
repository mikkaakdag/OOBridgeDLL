namespace OOBridgeDLL;

public class Car : Vehicle
{
    public Car(string licensePlate, DateTime date)
        : base(licensePlate, date)
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
}
