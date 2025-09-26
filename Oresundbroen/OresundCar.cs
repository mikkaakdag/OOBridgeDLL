using OOBridgeDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Oresundbroen;

public class OresundCar : Vehicle
{
    public OresundCar(string licensePlate, DateTime date, bool hasBrobizz)
        : base(licensePlate, date, hasBrobizz)
    {

    }

    public override double Price()
    {
        return 460;
    }

    public override string VehicleType()
    {
        return "Oresund Car";
    }

    public override double Brobizz()
    {
        if (HasBrobizz == true)
        {
            return 178;
        }
        else
        {
            return Price();
        }
    }

    public double WeekendDiscount()
    {
        if (VehicleType() == "Car" && Date.DayOfWeek == DayOfWeek.Saturday || VehicleType() == "Car" && Date.DayOfWeek == DayOfWeek.Sunday)
        {
            return Price() * 0.85;
        }
        else
        {
            return Price();
        }
    }

    public double WeekendBrobizz()
    {
        if (VehicleType() == "Car" && HasBrobizz == true && Date.DayOfWeek == DayOfWeek.Saturday || VehicleType() == "Car" && HasBrobizz == true && Date.DayOfWeek == DayOfWeek.Sunday)
        {
            return (Price() * 0.85) * 0.90;
        }
        else
        {
            return Price();
        }
    }
}
