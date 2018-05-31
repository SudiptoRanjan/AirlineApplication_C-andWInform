using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookTicketRepository
    {

        public bool Insert(Bookticket bTicket)
        {
            try
            {
                string query = "INSERT into BookTicket VALUES ('" + bTicket.BookTicketId + "', '" + bTicket.PassengerId + "', '" + bTicket.PassengerUsername +
                                "', '" + bTicket.Source + "', '" + bTicket.Destination + "', '" + bTicket.Departure + "', '" + bTicket.Arrival +
                                "', '" + bTicket.Airplane + "', '" + bTicket.Seats + "', " + bTicket.Cost + ")";
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

        /*public bool Update(Bookticket bt)
        {

            try
            {
                string query = "UPDATE Airplane SET Source = '" + bt.Source + "', Destination = '" + bt.Destination + "', Departure = '" + bt.Departure 
                                + "', Arrival = '" + bt.Arrival + "', Airplane = '" + bt.Airplane + "', '" + bTicket.Seats + "', " + bTicket.Cost + "'";
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
        }*/

        public bool Delete(string ticketId)
        {

            try
            {
                string query = "DELETE From BookTicket WHERE BookTicketId = '" + ticketId + "' ";
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

        public Bookticket GetTicket(string ticketId)
        {
            string query = "SELECT * from BookTicket WHERE BookTicketId  = '" + ticketId + "'";
            Bookticket b = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                b = new Bookticket();
                b.BookTicketId = sdr["BookTicketId"].ToString();
                b.PassengerId = sdr["PassengerId"].ToString();
                b.PassengerUsername = sdr["PassengerName"].ToString();
                b.Airplane = sdr["Airplane"].ToString();
                b.Source = sdr["Source"].ToString();
                b.Destination = sdr["Destination"].ToString();
                b.Departure = sdr["Departure"].ToString();
                b.Arrival = sdr["Arrival"].ToString();
                b.Seats = sdr["Seats"].ToString();
                b.Cost = Convert.ToInt32(sdr["Cost"]);

            }
            dcc.CloseConnection();
            return b;
        }

        public List<Bookticket> GetAllTickets()
        {
            string query = "SELECT * from BookTicket";
            List<Bookticket> tList = new List<Bookticket>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Bookticket b = new Bookticket();
                b.BookTicketId = sdr["BookTicketId"].ToString();
                b.PassengerId = sdr["PassengerId"].ToString();
                b.PassengerUsername = sdr["PassengerName"].ToString();
                b.Airplane = sdr["Airplane"].ToString();
                b.Source = sdr["Source"].ToString();
                b.Destination = sdr["Destination"].ToString();
                b.Departure = sdr["Departure"].ToString();
                b.Arrival = sdr["Arrival"].ToString();
                b.Seats = sdr["Seats"].ToString();
                b.Cost = Convert.ToInt32(sdr["Cost"]);

                tList.Add(b);

            }
            dcc.CloseConnection();
            return tList;
        }
    }
}
