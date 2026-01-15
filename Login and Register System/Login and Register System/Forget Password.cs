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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newfm = new Form1();
            newfm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; port = 3306; database= register_db ; username= root; password= ");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select password from register_table where username='" + textBox1.Text + "' and email = '" + textBox4.Text + "'";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Invalid username or email address!");
                }
                else
                {
                    MySqlCommand com = new MySqlCommand(cmd.CommandText, con);
                    com.CommandType = CommandType.Text;
                    MySqlParameter p1 = new MySqlParameter("@userName", textBox1.Text);
                    com.Parameters.Add(p1);
                    MySqlDataReader dr = com.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show( "Your Password: " + dr[0].ToString());
                    }

                    else
                    {
                        MessageBox.Show("User Name does not exist");
                    }
                    con.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
