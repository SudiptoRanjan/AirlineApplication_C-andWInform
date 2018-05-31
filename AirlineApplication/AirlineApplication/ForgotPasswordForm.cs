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
    public partial class ForgotPasswordForm : Form
    {

        private string ans;
        private string id;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //forgot pass submit btn
            id = this.textBox1.Text;
            ans = this.textBox2.Text;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\Github\AirlineApplication\airline.mdf;Integrated Security=True;Connect Timeout=30");

            PassengerRepository pRepo = new PassengerRepository();
            string query = "SELECT * from Passengers WHERE PassengerId = '" + id + "' and Question = '" + ans + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);


            EmployeeRepository rRepo = new EmployeeRepository();
            string query2 = "SELECT * from Employee WHERE EmployeeId = '" + id + "' and Question = '" + ans + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);
            DataTable tbl2 = new DataTable();
            sda2.Fill(tbl2);

            AdminRepository aRepo = new AdminRepository();
            string query3 = "SELECT * from Admin WHERE AdminId = '" + id + "' and Question = '" + ans + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, sqlcon);
            DataTable tbl3 = new DataTable();
            sda3.Fill(tbl3);



            if (tbl2.Rows.Count == 1)
            {

                //Console.WriteLine("a");
                textBox3.Text = Convert.ToString(tbl2.Rows[0]["Password"]);
                                
            }
            else if(tbl2.Rows.Count == 1)
            {
                textBox3.Text = Convert.ToString(tbl2.Rows[0]["Password"]);
                
            }
            else if (tbl3.Rows.Count == 1)
            {
                textBox3.Text = Convert.ToString(tbl3.Rows[0]["Password"]);

            }
            else
            {

                textBox3.Text = "Wrong ID or Movie";
                textBox1.Text = "";
                textBox2.Text = "";
                
            }



        }
    }
}
