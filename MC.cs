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

    protected override double GetBasePrice() 
    {
        return 120;
    }

    public override string VehicleType()
    {
        return "MC";
    }
}
