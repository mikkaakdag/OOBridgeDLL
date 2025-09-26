using OOBridgeDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Interface;

public interface IStorebæltsbroen
{
    void AddTicket (Vehicle ticket);                  
    List<Vehicle> GetAllTickets();                   
    List<Vehicle> GetTicketsByLicense (string plate); 
}
