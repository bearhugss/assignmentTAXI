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
    public partial class PassengerData : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nausheen\source\repos\taxiassign\taximain\taximain\TaxiUser.mdf;Integrated Security=True");

        public PassengerData()
        {
            InitializeComponent();
        }

        private void passengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxiUserDataSet1);

        }

        private void PassengerData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiUserDataSet1.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this.taxiUserDataSet1.Passenger);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select sum(Estimated_Fare_Amount) from Passenger";
            string str = Convert.ToString(cmd.ExecuteScalar());
            lbltotalestimated.Text = "Total Estimated Fare Amount:" + str;

            con.Close();
        }
    }
}
