using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBridgeDLL;

public abstract class Vehicle
{
    /// <summary>
    /// Vehicle-klassen har 3 properties og et instance field:
    /// LicensePlate af typen string
    /// Date af typen DateTime
    /// HasBrobizz as typen bool
    /// _licensePlate som er instance field'et
    /// </summary>

    public string _licensePlate;
    public string LicensePlate 
    { 
      get => _licensePlate;

      set
        {
            if (value.Length > 7)
            {
                throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn");
            }
            _licensePlate = value;
        }
    }
    public DateTime Date { get; set; }
    public bool HasBrobizz {  get; set; }


    /// <summary>
    /// Vehicle-klassens constructor har 3 parametre:
    /// licensePlate af typen string, date af typen DateTime, hasBrobizz af typen bool
    /// Disse initialiseres med properties'ene
    /// </summary>
    public Vehicle (string licensePlate, DateTime date, bool hasBrobizz)
    {
        LicensePlate = licensePlate;
        Date = date;
        HasBrobizz = hasBrobizz;
    }

    /// <summary>
    /// Der findes også 3 metoder:
    /// GetBasePrice, Price og VehicleType
    /// </summary>

    //public virtual double GetBasePrice()
    //{
    //    throw new NotImplementedException("Nedarvede klasser skal implementere GetBasePrice()");
    //}


    public abstract double Price();

    public abstract string VehicleType();

    public abstract double Brobizz();
}
