using System.Collections.Generic;

namespace Repository
{
    interface IPassengerRepository
    {
        bool Insert(Passenger p);
        bool Update(Passenger p);
        bool Delete(string  passengerId);
        Passenger GetPassengers(string userId);
        List<Passenger> GetAllPassengers();

    }
}