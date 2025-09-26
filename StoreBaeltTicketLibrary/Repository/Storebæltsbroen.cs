using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOBridgeDLL;

namespace StoreBaeltTicketLibrary.Repository;

public class Storebæltsbroen
{
    private static readonly List<Vehicle> _tickets = new List<Vehicle>();

    public void AddTickets (Vehicle ticket)
    {
        _tickets.Add(ticket);
    }

    public List<Vehicle> GetAllTickets()
    {
        return _tickets; 
    }

    // Hent billetter efter nummerplade
    public List<Vehicle> GetTicketsByLicense (string plate)
    {
        return _tickets
            .Where(t => t.LicensePlate.Equals(plate, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
