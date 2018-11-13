using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taximain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userinput ui = new Userinput();
            ui.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassengerData pd = new PassengerData();
            pd.Show();
        }
    }
}
