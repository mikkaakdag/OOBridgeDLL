using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBridgeDLL;

public class MC : Vehicle
{
    public MC (string licensePlate, DateTime date, bool hasBrobizz)
        : base (licensePlate, date, hasBrobizz)
    {

    }

    public override double Price() 
    {
        return 120;
    }

    public override string VehicleType()
    {
        return "MC";
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
