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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adduser_Click(object sender, EventArgs e)
        {
            try {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; user= root; password = ");
                string query = "insert into student.login (username,password) values('"+ textBox1.Text + "','" + textBox2.Text + "');";


                MySqlDataReader myReader;
                MySqlCommand myCommand = new MySqlCommand(query, connection);
                connection.Open();

                myReader = myCommand.ExecuteReader();

                MessageBox.Show("Data saved...");
                textBox1.Text = "";
                textBox2.Text = "";
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.Show();
            this.Hide();
        }
    }
}
