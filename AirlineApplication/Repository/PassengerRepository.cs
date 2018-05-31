using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class PassengerRepository : IPassengerRepository
    {
        public bool Insert(Passenger p)
        {
            try
            {
                string query = "INSERT into Passengers VALUES ('" + p.PassengerId + "', '" + p.Pname + "', '" +
                               p.Pusername + "','" + p.Pemail + "', '" + p.Ppassword + "', '" + p.Pgender +
                               "', " + p.Page +  ", '" + p.Paddress + "', '" + p.Pquestion + "')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                Console.WriteLine("x= " + x);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Update(Passenger pass)
        {
            try
            {
                string query = "UPDATE Passengers SET Name = '" + pass.Pname + "', UserName = '" +
                               pass.Pusername + "', Email = '" + pass.Pemail + "', Password = '" + pass.Ppassword + "', Gender = '" + pass.Pgender +
                               "', Age = " + pass.Page +  ", Address = '" + pass.Paddress 
                               + "', Question = '" + pass.Pquestion + "' WHERE PassengerId = '" + pass.PassengerId + "'";
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

        public bool Delete(string passengerId)
        {
            try
            {
                string query = "DELETE From Passengers WHERE PassengerId = '" + passengerId + "' ";
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

        public Passenger GetPassengers(string userId)
        {
            string query = "SELECT * from Passengers WHERE PassengerId = '" + userId + "'";
            Passenger p = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                p = new Passenger();
                p.PassengerId = sdr["PassengerId"].ToString();
                p.Pusername = sdr["Username"].ToString();
                p.Pname = sdr["Name"].ToString();
                p.Pemail = sdr["Email"].ToString();
                p.Pgender = sdr["Gender"].ToString();
                p.Paddress = sdr["Address"].ToString();
                p.Page = Convert.ToInt32(sdr["Age"]);
                p.Pquestion = sdr["Question"].ToString();
                p.Ppassword = sdr["Password"].ToString();
            }
            dcc.CloseConnection();
            return p;
        }

        public List<Passenger> GetAllPassengers()
        {
            string query = "SELECT * from Passengers";
            List<Passenger> pList = new List<Passenger>();
            
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Passenger p = new Passenger();
                p.PassengerId = sdr["PassengerId"].ToString();
                p.Pname = sdr["Name"].ToString();
                p.Pusername = sdr["UserName"].ToString();
                
                p.Pemail = sdr["Email"].ToString();
                p.Ppassword = sdr["Password"].ToString();
                p.Pgender = sdr["Gender"].ToString();
                p.Page = Convert.ToInt32(sdr["Age"]);
                p.Paddress = sdr["Address"].ToString();
                p.Pquestion = sdr["Question"].ToString();

                pList.Add(p);

            }
            dcc.CloseConnection();
            return pList;
        }
    }
}