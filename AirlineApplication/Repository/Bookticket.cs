using System;

namespace Repository
{
    public class Bookticket
    {
        private string bookTicketId;
        private int cost;
        private string passengerId;
        private string airplane;
        private string passengerUsername;
        private string departure;
        private string arrival;
        private string seats;                
        private string source;
        private string destination;

        public int Cost
        {
            get { return cost; }
            set { this.cost = value; }
        }

        public string BookTicketId
        {
            get { return  bookTicketId; }
            set { this.bookTicketId = value; }
        }

        public string PassengerId
        {
            get { return passengerId; }
            set { passengerId = value; }
        }

        public string Airplane
        {
            get { return airplane; }
            set { this.airplane = value; }
        }

        public string PassengerUsername
        {
            get { return passengerUsername; }
            set { this.passengerUsername = value; }
        }

        public string Source
        {
            get { return source; }
            set { this.source = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { this.destination = value; }
        }

        public string Departure
        {
            get { return departure; }
            set { this.departure = value; }
        }

        public string Arrival
        {
            get { return arrival; }
            set { this.arrival = value; }
        }

        public string Seats
        {
            get { return seats; }
            set { this.seats = value; }
        }


        
    }
}