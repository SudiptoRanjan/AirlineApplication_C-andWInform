using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class AirportRepository : IAirportRepository
    {
        public bool Insert(Airport airport)
        {
            try
            {
                string query = "INSERT into Airport VALUES ('" + airport.AirportId + "', '" + airport.AirportName + "', '" +
                               airport.City + "','" + airport.Airportcode + "')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Update(Airport airport)
        {
            try
            {
                string query = "UPDATE Airport SET AirportName = '" + airport.AirportName + "', City = '" +
                               airport.City + "', AirportCode = '" + airport.Airportcode + "' WHERE AirportId = '" + airport.AirportId + "'";
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

        public bool Delete(string airportId)
        {

            try
            {
                string query = "DELETE From Airport WHERE AirportId = '" + airportId + "' ";
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

        public Airport GetAirports(string airportId)
        {
            string query = "SELECT * from Airpprt WHERE AirportId = '" + airportId + "'";
            Airport air1 = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                air1 = new Airport();
                air1.AirportId = sdr["AirportID"].ToString();
                air1.AirportName = sdr["AirportName"].ToString();
                air1.City = sdr["City"].ToString();
                air1.Airportcode = sdr["AirportCode"].ToString();
                
            }
            dcc.CloseConnection();
            return air1;
        }

        public List<Airport> GetAllAirports()
        {
            string query = "SELECT * from Airport";
            List<Airport> airList = new List<Airport>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Airport air1=new Airport();

                air1 = new Airport();
                air1.AirportId = sdr["AirportID"].ToString();
                air1.AirportName = sdr["AirportName"].ToString();
                air1.City = sdr["City"].ToString();
                air1.Airportcode = sdr["AirportCode"].ToString();

                airList.Add(air1);

            }
            dcc.CloseConnection();
            return airList;
        }
    }
}