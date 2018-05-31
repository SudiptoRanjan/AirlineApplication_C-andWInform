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

namespace AirlineApplication
{
    public partial class SignUpForm : Form
    {
        
        
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
                   
            Passenger p = new Passenger();
            p.PassengerId = this.textBox11.Text;
            p.Pname = this.textBox1.Text;
            p.Pusername = this.textBox2.Text;
            p.Pemail = this.textBox3.Text;
                        
            if (this.textBox5.Text == this.textBox4.Text)
            {
                p.Ppassword = this.textBox5.Text;
            }
            else
            {
                wrongPasslabel.Text = "Password Don't match";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
            }

            p.Pgender = this.textBox6.Text;
            p.Page = Convert.ToInt32(this.textBox7.Text);
            p.Paddress = this.textBox9.Text;
            p.Pquestion = this.textBox10.Text;
            


            PassengerRepository PassengerRepo = new PassengerRepository();
            
            if (PassengerRepo.Insert(p))
            {
                AllUsersRepository userRepo = new AllUsersRepository();
                AllUsers a = new AllUsers();

                a.UserId = this.textBox11.Text;
                a.UserName = this.textBox2.Text;
                a.UserType = "Passenger";

                if (userRepo.Insert(a))
                {
                    MessageBox.Show("New User Added");
                }
                else
                {
                    MessageBox.Show("New User did not Added");

                }

                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Could not connect to database", "Insert Error");
            }

            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }
    }
}
