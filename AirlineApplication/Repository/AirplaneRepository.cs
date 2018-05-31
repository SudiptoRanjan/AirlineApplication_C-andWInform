using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AirplaneRepository:IAirplaneRepository
    {
        public bool Insert(Airplane air)
        {
            try
            {
                string query = "INSERT into Airplane VALUES ('" + air.AirplaneId + "', '" + air.AirplaneName +  "', " + air.Capacity + ")";
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

        public bool Update(Airplane air)
        {

            try
            {
                string query = "UPDATE Airplane SET AirplaneName = '" + air.AirplaneName 
                                + "', Capacity = " + air.Capacity + " WHERE AirplaneId = '" + air.AirplaneId + "'";
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

        public bool Delete(string airplaneId)
        {

            try
            {
                string query = "DELETE From Airplane WHERE AirplaneId = '" + airplaneId + "' ";
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

        public Airplane getAirplanes(string airplaneId)
        {
            string query = "SELECT * from Airplane WHERE AirplaneId  = '" + airplaneId + "'";
            Airplane air = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                air = new Airplane();
                air.AirplaneId = sdr["AirplaneId"].ToString();
                air.AirplaneName = sdr["AirplaneName"].ToString();
                air.Capacity = Convert.ToInt32(sdr["Capacity"]);
                
            }
            dcc.CloseConnection();
            return air;
        }

        public List<Airplane> GetAllAirplanes()
        {
            string query = "SELECT * from Airplane";
            List<Airplane> airList = new List<Airplane>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Airplane air= new Airplane();
                air.AirplaneId = sdr["AirplaneId"].ToString();
                air.AirplaneName = sdr["AirplaneName"].ToString();
                air.Capacity = Convert.ToInt32(sdr["Capacity"]);

                airList.Add(air);

            }
            dcc.CloseConnection();
            return airList;
        }
    }
}
