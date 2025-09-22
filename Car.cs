namespace OOBridgeDLL;

public class Car
{
    /// <summary>
    /// Car-klassen har 2 properties:
    /// LicensePlate af typen string
    /// Date af typen DateTime
    /// </summary>
    public string LicensePlate { get; set; }
    public DateTime Date { get; set; }

    /// <summary>
    /// Car-klassens constructor har 2 parametre:
    /// licensePlate af typen string, date af typen DateTime
    /// Disse initialiseres med properties'ene
    /// </summary>
    public Car (string licensePlate, DateTime date)
    {
        LicensePlate = licensePlate;
        Date = date;
    }
    
    /// <summary>
    /// Der findes også 2 metoder:
    /// Price og VehicleType
    /// </summary>
    public double Price()
    {
        return 230;
    }

    public string VehicleType()
    {
        return "Car";
    }


}
