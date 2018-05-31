using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace AirlineApplication
{
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void oooToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookTicketBtn_Click_1(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void passengerSearchBtn_Click(object sender, EventArgs e)
        {
            if (passengerComboBox.SelectedItem.ToString() == "Flight")
            {
                string text = this.passengerSearchTextBox.Text;
                string query = "SELECT * FROM Flight WHERE FlightID = '" + text + "' OR AirlineName LIKE '%" + text + "%' " + " OR Source LIKE '%" + text + "%' " + " OR Destination LIKE '%" + text + "%' " + " OR Cost LIKE '%" + text + "%' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                Flight f;
                List<Flight> fList = new List<Flight>();


                if (sdr.Read())
                {
                    f = new Flight();
                    f.FlightId = sdr["FlightID"].ToString();
                    f.AirlineName = sdr["AirlineName"].ToString();
                    f.Source = sdr["Source"].ToString();
                    f.Destination = sdr["Destination"].ToString();
                    f.Arrival = Convert.ToString(sdr["Arrival"]);
                    f.Departure = Convert.ToString(sdr["Departure"]);
                    f.Cost = Convert.ToInt32(sdr["Cost"]);

                    fList.Add(f);
                    
                }

                this.dataGridView2.DataSource = fList;

            }
            else if (passengerComboBox.SelectedItem.ToString() == "Airplanes")
            {
                string text = this.passengerSearchTextBox.Text;
                string query = "SELECT * FROM Airplane WHERE AirplaneId = '" + text + "' OR AirplaneName LIKE '%" + text + "%' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                Airplane air;
                List<Airplane> airList = new List<Airplane>();



                if (sdr.Read())
                {
                    air = new Airplane();
                    air.AirplaneId = sdr["AirplaneId"].ToString();
                    air.AirplaneName = sdr["AirplaneName"].ToString();
                    air.Capacity = Convert.ToInt32(sdr["Capacity"]);

                    airList.Add(air);

                }
                this.dataGridView2.DataSource = airList;

            }
            else if (passengerComboBox.SelectedItem.ToString() == "Airport")
            {
                string text = this.passengerSearchTextBox.Text;
                string query = "SELECT * FROM Airport WHERE AirportId = '" + text + "' OR AirportName LIKE '%" + text + "%' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                Airport air1;
                List<Airport> air1List = new List<Airport>();



                if (sdr.Read())
                {
                    air1 = new Airport();


                    
                    air1.AirportId = sdr["AirportID"].ToString();
                    air1.AirportName = sdr["AirportName"].ToString();
                    air1.City = sdr["City"].ToString();
                    air1.Airportcode = sdr["AirportCode"].ToString();

                    air1List.Add(air1);

                }
                this.dataGridView2.DataSource = air1List;

            }            
            else if (passengerComboBox.SelectedItem.ToString() == "Booked Flight")
            {
                string text = this.passengerSearchTextBox.Text;
                string query = "SELECT * FROM BookTicket WHERE BookTicketId = '" + text + "' OR PassengerId LIKE '%" + text + "%' OR PassengerName LIKE '%" + text + "%' OR Seats LIKE '" + text + "%' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                Bookticket b;
                List<Bookticket> bList = new List<Bookticket>();
                
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

                    bList.Add(b);

                }
                this.dataGridView2.DataSource = bList;

            }
            else
            {
                MessageBox.Show("Search error");
            }
        }

        private void bookTicketBtn_Click_2(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void loadFlightsBtn_Click(object sender, EventArgs e)
        {
            FLightRepository flightRepo = new FLightRepository();

            List<Flight> flightList = flightRepo.GetALlFlights();

            this.dataGridView2.DataSource = flightList;
        }

        private void loadBookedFilghts_Click(object sender, EventArgs e)
        {
            Bookticket bt = new Bookticket();
            BookTicketRepository btRepo = new BookTicketRepository();
            string text = passengerSearchTextBox.Text;

            if (text == "")
            {
                List<Bookticket> btList = btRepo.GetAllTickets();
                dataGridView2.DataSource = btList;
            }
            else
            {
                Bookticket b2 = btRepo.GetTicket(text);
                List<Bookticket> btList = new List<Bookticket>();
                btList.Add(b2);
                dataGridView2.DataSource = btList;

            }


        }

        private void viewAirports_Click(object sender, EventArgs e)
        {
            AirportRepository airRepo = new AirportRepository();

            List<Airport> airList = airRepo.GetAllAirports();

            this.dataGridView2.DataSource = airList;
        }

        private void viewAirplaneBtn_Click(object sender, EventArgs e)
        {
            AirplaneRepository airPlane = new AirplaneRepository();

            List<Airplane> airList = airPlane.GetAllAirplanes();

            this.dataGridView2.DataSource = airList;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //logout btn 
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }
    }
}
