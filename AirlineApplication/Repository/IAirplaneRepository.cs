using System.Collections.Generic;
using Repository;

namespace Repository
{
    interface IAirplaneRepository
    {
        bool Insert(Airplane air);
        bool Update(Airplane air);
        bool Delete(string airplaneId);
        Airplane getAirplanes(string airplaneId);
        List<Airplane> GetAllAirplanes();
    }
}