using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBridgeDLL;

public class MC
{
    /// <summary>
    /// MC klassen har 2 properties:
    /// LicensePlate med typen string
    /// Date med typen DateTime
    /// </summary>
    public string LicensePlate {  get; set; }
    public DateTime Date {  get; set; }

    /// <summary>
    /// MC-klassens constructor har 2 parametre:
    /// licensePlate af typen string, date af typen DateTime
    /// Disse initialiseres med properties'ene
    /// </summary>
    public MC (string licensePlate, DateTime date)
    {
        LicensePlate = licensePlate;
        Date = date;
    }

    /// <summary>
    /// Der findes også 2 metoder:
    /// Price og Vehicle
    /// </summary>
    public double Price()
    {
        return 120;
    }

    public string Vehicle()
    {
        return "MC";
    }
}
