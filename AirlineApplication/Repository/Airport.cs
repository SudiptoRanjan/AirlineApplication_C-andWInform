using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Repository
{
    public class Airport
    {

        private string airportId;
        private string airportName;
        private string city;
        private string airportcode;

        public string AirportId
        {
            get { return airportId; }
            set { airportId = value; }
        }
        public string AirportName
        {
            get { return airportName; }
            set { airportName = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Airportcode
        {
            get { return airportcode; }
            set { airportcode = value; }
        }

    }
}