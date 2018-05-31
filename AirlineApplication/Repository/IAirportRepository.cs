using System.Collections.Generic;

namespace Repository
{
    interface IAirportRepository
    {
        bool Insert(Airport airport);
        bool Update(Airport airport);
        bool Delete(string airportId);
        Airport GetAirports(string airportId);
        List<Airport> GetAllAirports();

    }
}