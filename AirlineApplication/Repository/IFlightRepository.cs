using System.Collections.Generic;

namespace Repository
{
    interface IFlightRepository
    {
        bool Insert(Flight f);
        bool Update(Flight f);
        bool Delete(string flightId);
        Flight GetFlight(string flightId);
        List<Flight> GetALlFlights();
        

    }
}