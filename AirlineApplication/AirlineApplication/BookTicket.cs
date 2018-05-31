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
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load flights btn
            int y = 80;
            int sum = 5;
            
            string query = "SELECT * FROM Flight";

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\Github\AirlineApplication\airline.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader sdr = dcc.GetData(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);

            while (sdr.Read())
            {
                Flight f = new Flight();

                f.AirlineName = sdr["AirlineName"].ToString();
                f.FlightId = sdr["FlightID"].ToString();
                f.Source = sdr["Source"].ToString();
                f.Destination = sdr["Destination"].ToString();
                f.Departure = sdr["Departure"].ToString();
                f.Arrival = sdr["Arrival"].ToString();
                f.Cost = Convert.ToInt32(sdr["Cost"]);

                Label label1 = new Label();
                label1.AutoSize = false;
                label1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sum = sum + y;
                label1.Location = new System.Drawing.Point(34, sum);
                label1.Text = "Airline-" + f.AirlineName + ", From-" + f.Source + ", To-" + f.Destination + ",  Departure-" + f.Departure + ",  Arrival-" + f.Arrival + ",  Cost-" + f.Cost;
                label1.Size = new System.Drawing.Size(800, 50);
                label1.Click += new System.EventHandler(this.flightLabel_click);


                foreach (DataRow row in tbl.Rows)
                {

                    for (int i = 0; i < tbl.Rows.Count; i++)
                    {
                                                   
                        selectFlightTab.Controls.Add(label1);
                        
                    }

                }
            }
        }


        public void flightLabel_click(Object sender, EventArgs e)
        {
            this.bookTicketTabs.SelectTab(1);
            Label lbl = (Label)sender;

            string[] text = lbl.Text.Split(',', '-');           


            airplaneLabel.Text = text[1];
            fromComboBox.SelectedText = text[3];
            toComboBox.SelectedText = text[5];
            dateTimePicker1.Text = text[7];
            dateTimePicker2.Text = text[9];
            costLabel.Text = text[11];

            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void seat1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            seatLabel.Text = seatLabel.Text + ", " +  btn.Text;
            btn.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void submitBookTicketBtn_Click(object sender, EventArgs e)
        {
            Bookticket bt = new Bookticket();
            bt.BookTicketId = textBox21.Text;
            bt.PassengerId = textBox22.Text;
            bt.PassengerUsername = textBox23.Text;
            bt.Airplane = airplaneLabel.Text;
            bt.Source = fromComboBox.Text;
            bt.Destination = toComboBox.Text;
            bt.Departure = dateTimePicker1.Text;
            bt.Arrival = dateTimePicker2.Text;
            bt.Cost = Convert.ToInt32(costLabel.Text);
            bt.Seats = seatLabel.Text;

            BookTicketRepository btRepo = new BookTicketRepository();

            if (btRepo.Insert(bt))
            {
                MessageBox.Show("Ticket Booked");
            }
            else
            {
                MessageBox.Show("Error adding ticket");
            }
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            //book ticket back btn
            PassengerForm pf = new PassengerForm();
            pf.Show();
            this.Hide();
        }
    }
}
