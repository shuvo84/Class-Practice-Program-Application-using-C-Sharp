using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBaseConnection
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; user= root; password = ");
                connection.Open();
                if(connection.State == ConnectionState.Open)
                {
                    connectionlabel.Text = "Database Connected...Enjoy!!";
                    connectionlabel.ForeColor = Color.Green;
                }
                else
                {
                    connectionlabel.Text = "Sorry!! Not Connected...Try Again...";
                    connectionlabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
          
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
