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

namespace taximain
{
    
    public partial class Userinput : Form
    {
        int km;
        double fare;
        int hr;
        double totalfare;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nausheen\source\repos\taxiassign\taximain\taximain\TaxiUser.mdf;Integrated Security=True");
        public Userinput()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbam.Checked)
            {
                tbtime.Text = tbtime.Text + cbhr.Text + ":" + cbmin.Text  ;   
                tbtime.Text = tbtime.Text + "AM";

            }
            else if (rbpm.Checked)
            {
                tbtime.Text = tbtime.Text + cbhr.Text + ":" + cbmin.Text;
                tbtime.Text = tbtime.Text + "PM";

            }
            else
            {
                MessageBox.Show("Please check time");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           km = Convert.ToInt16(tbkilometers.Text);


            if(km<=3)
            {
                fare = 50;
                tbfareamount.Text = Convert.ToString(fare);
                
            }
            else
            {
                fare = 50 + ((km-3) * 20);
                tbfareamount.Text = Convert.ToString(fare);
                
            }
            fare=Convert.ToInt16(fare);
            if (rbam.Checked)
            {
                hr = Convert.ToInt16(cbhr.Text);
                if ((hr >= 7) && (hr < 9))
                {
                    totalfare = fare * 1.5;
                    tbfareamount.Text = Convert.ToString(totalfare);
                    MessageBox.Show("Total Fare is " + totalfare);
                }
                else
                {
                    totalfare = fare;
                    tbfareamount.Text = Convert.ToString(totalfare);
                    MessageBox.Show("Total Fare is " + totalfare);
                }
            }
            else if(rbpm.Checked)
            { 

                 hr = Convert.ToInt16(cbhr.Text);
                 if ((hr >= 6) && (hr < 8))
                  {
                      totalfare = fare * 1.5;
                      tbfareamount.Text = Convert.ToString(totalfare);
                      MessageBox.Show("Total Fare is " + totalfare);
                   }
                   else
                   {
                         totalfare = fare;
                         tbfareamount.Text = Convert.ToString(totalfare);
                         MessageBox.Show("Total Fare is " + totalfare);
                    }

            }           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Passenger values(" + tbpassengerid.Text + ",'" + tbpassengername.Text + "','" + tbtime.Text + "'," + tbfareamount.Text + ")";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Inserted to Database");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Userinput_Load(object sender, EventArgs e)
        {
           
        }
    }
}
