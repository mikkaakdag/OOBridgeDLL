using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBridgeDLL;

public class Vehicle
{
    /// <summary>
    /// Vehicle-klassen har 2 properties:
    /// LicensePlate af typen string
    /// Date af typen DateTime
    /// </summary>
    public string LicensePlate { get; set; }
    public DateTime Date { get; set; }

    /// <summary>
    /// Vehicle-klassens constructor har 2 parametre:
    /// licensePlate af typen string, date af typen DateTime
    /// Disse initialiseres med properties'ene
    /// </summary>
    public Vehicle (string licensePlate, DateTime date)
    {
        LicensePlate = licensePlate;
        Date = date;
    }

    /// <summary>
    /// Der findes også 2 metoder:
    /// Price og VehicleType
    /// </summary>
    public virtual double Price()
    {
        return 0;
    }

    public virtual string VehicleType()
    {
        return "Vehicle";
    }

}
