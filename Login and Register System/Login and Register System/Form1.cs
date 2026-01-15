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

namespace Login_and_Register_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; port = 3306; database= register_db ; username= root; password= ");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from register_table where username='" + username.Text + "' and password = '"+password.Text+"'";
             
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Invalid username or password");
                }
                else
                {
                    MessageBox.Show("Logged In Successfully!!");
                }
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 newfm = new Form3();
            newfm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 newfm = new Form4();
            newfm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
        }
    }
}
