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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("username cannot be Blank!");
            }

            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("password cannot be Blank!");
            }

            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password didn't match!");
            }

            else if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                MessageBox.Show("Email is requried!");
            }

            else if (string.IsNullOrEmpty(textBox5.Text) == true)
            {
                MessageBox.Show("Phone Number is requried!");
            }

            else if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Please enter correct date! Birth Date cannot be a future date!!");
            }

            else
            {
                try
                {


                    MySqlConnection con = new MySqlConnection("datasource= localhost; port = 3306; database= register_db ; username= root; password= ");
                    con.Open();
                    string insertQuery = "insert into register_table (`username`, `password`, `email`, `phone no`, `date of birth`) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "');";
                    MySqlCommand mycom = new MySqlCommand(insertQuery, con);
                    mycom.ExecuteNonQuery();
                    MessageBox.Show("Data Saved and SignUp Complete!!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
