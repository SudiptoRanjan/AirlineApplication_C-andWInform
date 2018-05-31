using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class FLightRepository : IFlightRepository
    {
        public bool Insert(Flight f)
        {
            //string query2 = "INSERT into Flight VALUES ('" + f.FlightId + "', '" + f.AirlineName + "', '" + f.Source + "', '" + f.Destination + "', '" + f.Arrival + "', '" + f.Departure + "', " + f.Cost + ")";
            try
            {
                string query = "INSERT into Flight VALUES ('" + f.FlightId + "', '" + f.AirlineName + "', '" + f.Source + "', '" + f.Destination + "', '" + f.Arrival + "', '" + f.Departure + "', " + f.Cost + ")";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "error database");
                //Console.WriteLine(query2);
                return false;
            }
        }

        public bool Update(Flight f)
        {
            try
            {
                string query = "UPDATE Flight SET AirlineName = '" + f.AirlineName + "', Source = '" + f.Source + "', Destination = '" + f.Destination + "',  Arrival = '" + f.Arrival + "', Departure = '" + f.Departure + "', Cost = " + f.Cost + " WHERE FlightID = '" + f.FlightId + "'";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "error database");
                return false;
            }
        }

        public bool Delete(string flightId)
        {
            try
            {
                string query = "DELETE From Flight WHERE FlightID = '" + flightId + "' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);

                dcc.CloseConnection();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        public Flight GetFlight(string flightId)
        {
            string query = "SELECT * from Flight WHERE FlightID = '" + flightId + "' or AirlineName LIKE '%" + flightId + "%'  ";
            Flight f = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                f=new Flight();
                f.FlightId = sdr["FlightID"].ToString();
                f.AirlineName = sdr["AirlineName"].ToString();
                f.Source = sdr["Source"].ToString();
                f.Destination = sdr["Destination"].ToString();
                f.Arrival = Convert.ToString(sdr["Arrival"]);
                f.Departure = Convert.ToString(sdr["Departure"]);
                f.Cost = Convert.ToInt32(sdr["Cost"]);


            }
            dcc.CloseConnection();
            return f;
        }

        public List<Flight> GetALlFlights()
        {
            string query = "SELECT * from Flight";
            List<Flight> fList = new List<Flight>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                var f=new Flight();
                f.FlightId = sdr["FlightID"].ToString();
                f.AirlineName = sdr["AirlineName"].ToString();
                f.Source = sdr["Source"].ToString();
                f.Destination = sdr["Destination"].ToString();
                f.Arrival = Convert.ToString(sdr["Arrival"]);
                f.Departure = Convert.ToString(sdr["Departure"]);
                f.Cost = Convert.ToInt32(sdr["Cost"]);

                fList.Add(f);


            }
            dcc.CloseConnection();
            return fList;
        }
    }
}