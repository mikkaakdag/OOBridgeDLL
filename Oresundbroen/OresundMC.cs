using OOBridgeDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbroen;

public class OresundMC : Vehicle
{
    public OresundMC(string licensePlate, DateTime date, bool hasBrobizz)
     : base(licensePlate, date, hasBrobizz)
    {

    }

    public override double Price()
    {
        return 235;
    }

    public override string VehicleType()
    {
        return "Oresund MC";
    }

    public override double Brobizz()
    {
        if (HasBrobizz == true)
        {
            return 92;
        }
        else
        {
            return Price();
        }
    }
}
