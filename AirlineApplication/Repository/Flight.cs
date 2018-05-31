using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Flight
    {
        private string flightId;
        private string airlineName;
        private string source;
        private string destination;
        private string arrival;
        private string departure;
        private int cost;

        public string FlightId
        {
            get { return flightId; }
            set { flightId = value; }
        }

        public string AirlineName
        {
            get { return airlineName; }
            set { airlineName = value; }
        }

        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string Arrival
        {
            get { return arrival;}
            set { arrival = value; }
        }

        public string Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

    
    }
}
