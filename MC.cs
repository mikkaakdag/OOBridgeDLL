﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBridgeDLL;

public class MC : Vehicle
{
    public MC (string licensePlate, DateTime date)
        : base (licensePlate, date)
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
}
