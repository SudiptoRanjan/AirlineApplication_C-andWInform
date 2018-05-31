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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUpForm sign = new SignUpForm();

            sign.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHomeForm admin = new AdminHomeForm();

            admin.Show();
            this.Hide();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uname = this.userTextBox1.Text.ToString();
            string upass = this.passTextBox2.Text.ToString();
            Console.WriteLine("user: " + uname);
            Console.WriteLine("pass: " + upass);

            AdminRepository adminRepo = new AdminRepository();
            EmployeeRepository empRepo = new EmployeeRepository();
            PassengerRepository passRepo = new PassengerRepository();

            List<Admin> adminList = adminRepo.GetAllAdmins();
            List<Employee> empList = empRepo.GetAllEmployees();
            List<Passenger> passList = passRepo.GetAllPassengers();

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\Github\AirlineApplication\airline.mdf;Integrated Security=True;Connect Timeout=30");
            /*string query = "SELECT * from Admin WHERE Username = '" + uname + "' and Password = '" + upass + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);*/



            if (admin.Checked == true)
            {

                string query = "SELECT * from Admin WHERE Username = '" + uname + "' and Password = '" + upass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                if (tbl.Rows.Count == 1)
                {
                    AdminHomeForm aform = new AdminHomeForm();
                    aform.Show();
                    this.Hide();
                }
                else
                {
                    passWLabel.Text = "Wrong User or Password.";
                    userTextBox1.Clear();
                    passTextBox2.Clear();
                }



            }
            else if (employeeRbtn.Checked == true)
            {
                string query = "SELECT * from Employee WHERE Username = '" + uname + "' and Password = '" + upass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                if (tbl.Rows.Count == 1)
                {
                    EmployeeForm eform = new EmployeeForm();
                    eform.Show();
                    this.Hide();
                }
                else
                {
                    passWLabel.Text = "Wrong User or Password.";
                    userTextBox1.Clear();
                    passTextBox2.Clear();
                }
            }
            else
            {
                string query = "SELECT * from Passengers WHERE UserName = '" + uname + "' and Password = '" + upass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable tbl = new DataTable();
                sda.Fill(tbl);

                if (tbl.Rows.Count == 1)
                {
                    PassengerForm pform = new PassengerForm();
                    pform.Show();
                    this.Hide();
                }
                else
                {
                    passWLabel.Text = "Wrong User or Password.";
                    userTextBox1.Clear();
                    passTextBox2.Clear();
                }
            }

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PassengerForm pform = new PassengerForm();
            pform.Show();
            this.Hide();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm fpForm = new ForgotPasswordForm();
            fpForm.Show();
            this.Hide();

        }
    }
}
