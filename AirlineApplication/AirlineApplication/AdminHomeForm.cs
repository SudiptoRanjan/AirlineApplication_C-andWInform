using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using System.Data.SqlClient;

namespace AirlineApplication
{
    public partial class AdminHomeForm : Form
    {
        //private int flightCount = 0;

        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void addNewFlightTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addFlightsTab_Click(object sender, EventArgs e)
        {

        }

        private void viewFlightTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            FLightRepository repository = new FLightRepository();
            List<Flight> flightList = repository.GetALlFlights();
            this.flightGridView1.DataSource = flightList;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            this.addEmpTab.SelectTab(1);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(3);
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add flight btn
            Flight f = new Flight();
            
            f.FlightId = this.textBox8.Text;
            f.AirlineName = this.textBox9.Text;
            f.Source = this.textBox10.Text;
            f.Destination = this.textBox11.Text;
            f.Arrival = this.dateTimePicker1.Text;
            f.Departure = this.dateTimePicker2.Text;
            f.Cost = Convert.ToInt32(this.textBox14.Text);
            



            FLightRepository FlightRepo = new FLightRepository();
            if (FlightRepo.Insert(f))
            {
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";                
                this.textBox14.Text = "";
                MessageBox.Show("Successfully Added", "Done");
            }
            else
            {
                MessageBox.Show("Error storing Flight", "Error");
            }


        }

        private void passengerGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //load passenger btn
            PassengerRepository passRepo = new PassengerRepository();
            List<Passenger> passList = passRepo.GetAllPassengers();
            this.passengerGridView2.DataSource = passList;

            this.textBox39.Text = "";
            this.textBox40.Text = "";
            this.textBox41.Text = "";
            this.textBox42.Text = "";
            this.textBox43.Text = "";
            this.textBox44.Text = "";
            this.textBox45.Text = "";
            this.textBox47.Text = "";
            this.textBox48.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //search passenger btn
            string uid = this.textBox38.Text;
            PassengerRepository PassRepo = new PassengerRepository();
            Passenger passList = PassRepo.GetPassengers(uid);
            this.passengerGridView2.DataSource = passList;
            this.textBox39.Text = passList.PassengerId;
            this.textBox40.Text = passList.Pname;
            this.textBox41.Text = passList.Pusername;
            this.textBox42.Text = passList.Pemail;
            this.textBox43.Text = passList.Ppassword;
            this.textBox44.Text = passList.Pgender;
            this.textBox45.Text = passList.Page.ToString();
            this.textBox47.Text = passList.Paddress;
            this.textBox48.Text = passList.Pquestion;
            this.passengerGridView2.DataSource = passList;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update passenger btn

            
                PassengerRepository PassRepo = new PassengerRepository();
                Passenger p = new Passenger();

                p.PassengerId = this.textBox38.Text;
                p.Pname = this.textBox40.Text;
                p.Pusername = this.textBox41.Text;
                p.Pemail = this.textBox42.Text;
                p.Ppassword = this.textBox43.Text;
                p.Pgender = this.textBox44.Text;
                p.Page = Convert.ToInt32(this.textBox45.Text);
                p.Paddress = this.textBox47.Text;
                p.Pquestion = this.textBox48.Text;

                if (PassRepo.Update(p))
                {
                    List<Passenger> pList = PassRepo.GetAllPassengers();
                    this.passengerGridView2.DataSource = pList;
                    this.textBox40.Text = "";
                    this.textBox41.Text = "";
                    this.textBox42.Text = "";
                    this.textBox43.Text = "";
                    this.textBox44.Text = "";
                    this.textBox45.Text = "";
                    this.textBox47.Text = "";
                    this.textBox48.Text = "";

                }
                else
                {
                    MessageBox.Show("Error", "Error");
                }
           
            


        }

        private void newRouteTab_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
        }

        private void addNewRouteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void loadUsersBtn_Click(object sender, EventArgs e)
        {
            AllUsersRepository userRepo = new AllUsersRepository();
            List<AllUsers> ulist = userRepo.GetAllUsers();

            this.userGridView1.DataSource = ulist;

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            Employee emp = new Employee();


            emp.EmployeeID = textBox70.Text;
            emp.Name = textBox71.Text;
            emp.Username = textBox72.Text;
            emp.Email = textBox73.Text;
            emp.Password = textBox74.Text;
            emp.Gender = textBox75.Text;
            emp.Age = Convert.ToInt32(textBox76.Text);
            emp.Address = textBox78.Text;
            emp.Question = textBox79.Text;

            if (empRepo.Insert(emp))
            {
                AllUsersRepository userRepo = new AllUsersRepository();
                AllUsers user = new AllUsers();

                user.UserId = emp.EmployeeID;
                user.UserType = "Employee";
                user.UserName = emp.Username;

                if (userRepo.Insert(user))
                {
                    MessageBox.Show("New User Added");
                }
                else
                {
                    MessageBox.Show("New User did not Added");

                }
            }
            else
            {
                MessageBox.Show("Error adding employee to database.");

            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            //add admin btn
            AdminRepository adminRepo = new AdminRepository();
            Admin a = new Admin();


            a.AdminId = textBox70.Text;
            a.Name = textBox71.Text;
            a.Username = textBox72.Text;
            a.Email = textBox73.Text;
            a.Password = textBox74.Text;
            a.Gender = textBox75.Text;
            a.Age = Convert.ToInt32(textBox76.Text);
            a.Address = textBox78.Text;
            a.Question = textBox79.Text;

            if (adminRepo.Insert(a))
            {
                AllUsersRepository userRepo = new AllUsersRepository();
                AllUsers user = new AllUsers();

                user.UserId = a.AdminId;
                user.UserType = "Admin";
                user.UserName = a.Username;

                if (userRepo.Insert(user))
                {
                    MessageBox.Show("New User Added");
                }
                else
                {
                    MessageBox.Show("New User did not Added");

                }

            }
            else
            {
                MessageBox.Show("Error adding admin to database.");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //logout btn
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            string uid = this.viewFlightTextBox.Text;
            FLightRepository fltRepo = new FLightRepository();
            Flight f = fltRepo.GetFlight(uid);
            List<Flight> fList = fltRepo.GetALlFlights();

            this.flightIdtextBox.Text = f.FlightId;
            this.textBox26.Text = f.AirlineName;
            this.textBox27.Text = f.Source;
            this.textBox28.Text = f.Destination;
            this.dateTimePicker3.Text = f.Departure;
            this.dateTimePicker4.Text = f.Arrival;
            this.textBox31.Text = Convert.ToString(f.Cost);
            
            this.passengerGridView2.DataSource = fList[0];


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            FLightRepository flightRepo = new FLightRepository();
            Flight f = new Flight();

            f.FlightId = this.flightIdtextBox.Text;
            f.AirlineName = this.textBox26.Text;
            f.Source = this.textBox27.Text;
            f.Destination = this.textBox28.Text;
            f.Departure = this.dateTimePicker3.Text;
            f.Arrival = this.dateTimePicker4.Text;
            f.Cost = Convert.ToInt32(this.textBox31.Text);

            if (flightRepo.Update(f))
            {
                List<Flight> fList = flightRepo.GetALlFlights();

                this.employeeGridView.DataSource = fList;
                this.flightIdtextBox.Text = "";
                this.textBox26.Text = "";
                this.textBox27.Text = "";
                this.textBox28.Text = "";
                this.dateTimePicker3.Text = "";
                this.dateTimePicker4.Text = "";
                this.textBox31.Text = "";

            }
            else
            {
                MessageBox.Show("Error", "Error");
            }

        }

        private void viewAllUsersBtn_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(4);

        }

        private void addemployeeBtn_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(5);

        }

        private void addAdminBtn2_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(6);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //
            EmployeeRepository empRepo = new EmployeeRepository();
            List<Employee> empList = empRepo.GetAllEmployees();
            this.employeeGridView.DataSource = empList;

            this.emptextBox3.Text = "";
            this.emptextBox4.Text = "";
            this.emptextBox1.Text = "";
            this.emptextBox6.Text = "";
            this.emptextBox7.Text = "";
            this.emptextBox8.Text = "";
            this.emptextBox9.Text = "";
            this.emptextBox2.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //search emp
            string uid = this.EmployeeSearchBox.Text;
            EmployeeRepository empRepo = new EmployeeRepository();
            Employee emp = empRepo.GetEmployees(uid);

            this.emptextBox1.Text = emp.EmployeeID;
            this.emptextBox2.Text = emp.Name;
            this.emptextBox3.Text = emp.Username;
            this.emptextBox4.Text = emp.Email;
            this.emptextBox5.Text = emp.Password;
            this.emptextBox6.Text = emp.Gender;
            this.emptextBox7.Text = emp.Age.ToString();
            this.emptextBox8.Text = emp.Address;
            this.emptextBox9.Text = emp.Question; 
            this.employeeGridView.DataSource = emp;


        }

        private void empUpdate_Click(object sender, EventArgs e)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            Employee emp = new Employee();

            emp.EmployeeID = this.emptextBox1.Text;
            emp.Name = this.emptextBox2.Text;
            emp.Username = this.emptextBox3.Text;
            emp.Email = this.emptextBox4.Text;
            emp.Password = this.emptextBox5.Text;
            emp.Gender = this.emptextBox6.Text;
            emp.Age = Convert.ToInt32(this.emptextBox7.Text);
            emp.Address = this.emptextBox8.Text;
            emp.Question = this.emptextBox9.Text;
                       
            if (empRepo.Update(emp))
            {
                List<Employee> empList = empRepo.GetAllEmployees();

                this.employeeGridView.DataSource = empList;
                this.emptextBox3.Text = "";
                this.emptextBox4.Text = "";
                this.emptextBox1.Text = "";
                this.emptextBox6.Text = "";
                this.emptextBox7.Text = "";
                this.emptextBox8.Text = "";
                this.emptextBox9.Text = "";
                this.emptextBox2.Text = "";

            }
            else
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //delete flight btn
            Flight f = new Flight();

            f.FlightId = flightIdtextBox.Text;

            FLightRepository fRepo = new FLightRepository();


            if (fRepo.Delete(f.FlightId))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("error deleting flight");
            }

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //delete passenger btn
            PassengerRepository pRepo = new PassengerRepository();
            Passenger p = new Passenger();

            p.PassengerId = textBox38.Text;

            if (pRepo.Delete(p.PassengerId))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Error deleting passenger");
            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //delete emp btn
            EmployeeRepository empRepo = new EmployeeRepository();

            Employee emp = new Employee();

            emp.EmployeeID = emptextBox1.Text;

            if (empRepo.Delete(emp.EmployeeID))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Error deleting employee");
            }



        }

        private void searchAllBtn_Click(object sender, EventArgs e)
        {

            string uid = this.searchAlltextBox1.Text;
            AllUsersRepository userRepo = new AllUsersRepository();
            List<AllUsers> aList = new List<AllUsers>();
            AllUsers a = userRepo.GetUser(uid);

            aList.Add(a);
            

            userGridView1.DataSource = aList;

            
        }

        private void viewEmpsBtn_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(7);
        }
    }
}
