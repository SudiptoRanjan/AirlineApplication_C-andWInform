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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empBookTicketBtn_Click(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void empSearchBtn_Click(object sender, EventArgs e)
        {
            if (employeeComboBox.SelectedItem.ToString() == "Flight")
            {

                string text = this.employeeSearchTextBox.Text;
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
                    Console.WriteLine("s");
                }

                this.dataGridView2.DataSource = fList;


            }
            else if (employeeComboBox.SelectedItem.ToString() == "Airplanes")
            {
                string text = this.employeeSearchTextBox.Text;
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

            else if (employeeComboBox.SelectedItem.ToString() == "Airport")
            {
                string text = this.employeeSearchTextBox.Text;
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

            else if (employeeComboBox.SelectedItem.ToString() == "Passengers")
            {
                string text = this.employeeSearchTextBox.Text;
                string query = "SELECT * FROM Passengers WHERE PassengerId = '" + text + "' OR Name LIKE '%" + text + "%' " + " OR UserName LIKE '%" + text + "%' " + " OR Email LIKE '%" + text + "%' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                SqlDataReader sdr = dcc.GetData(query);
                Passenger p;
                List<Passenger> pList = new List<Passenger>();



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

                    pList.Add(p);
                }
                this.dataGridView2.DataSource = pList;

            }

            else
            {
                MessageBox.Show("Search error");
            }
        }

        private void empBookTicketBtn_Click_1(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void viewFlights_Click(object sender, EventArgs e)
        {
            FLightRepository flightRepo = new FLightRepository();

            List<Flight> flightList = flightRepo.GetALlFlights();

            this.dataGridView2.DataSource = flightList;
        }

        private void viewPassengers_Click(object sender, EventArgs e)
        {
            PassengerRepository passRepo = new PassengerRepository();

            List<Passenger> passList = passRepo.GetAllPassengers();

            this.dataGridView2.DataSource = passList;
        }

        private void viewAirplanesBtn_Click(object sender, EventArgs e)
        {
            AirplaneRepository airPlane = new AirplaneRepository();

            List<Airplane> airList = airPlane.GetAllAirplanes();

            this.dataGridView2.DataSource = airList;
        }

        private void viewAirportBtn_Click(object sender, EventArgs e)
        {
            AirportRepository airRepo = new AirportRepository();

            List<Airport> airList = airRepo.GetAllAirports();

            this.dataGridView2.DataSource = airList;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }
    }
}
