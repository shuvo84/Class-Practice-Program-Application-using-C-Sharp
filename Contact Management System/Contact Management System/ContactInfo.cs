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

namespace Contact_Management_System
{
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
            gridView();
        }
        
        private void Cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ContactInfo_Load(object sender, EventArgs e)
        {
            cmb_type.Items.Add("");
            cmb_type.Items.Add("Home");
            cmb_type.Items.Add("Business");
            cmb_type.Items.Add("Personal");
        }

        private void Bt_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_address.Clear();
            

        }

        private void Bt_insert_Click(object sender, EventArgs e)
        {
            try
            {
             MySqlConnection con = new MySqlConnection("datasource= localhost; port = 3306; username= root; password= ");
                con.Open();
                string insertQuery = "insert into contactinfo.cinformation ( `name`, `phone`, `email`, `address`, `Type`) values('"+ txt_name.Text+"', '" + txt_phone.Text+"', '" + txt_email.Text+"','" + txt_address.Text+"','" + cmb_type.SelectedItem.ToString()+"');";
                MySqlCommand mycom = new MySqlCommand(insertQuery,con);
                mycom.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                gridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void gridView()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; port = 3306; username= root; password= ");
                con.Open();
                string displayQuery = "select * from contactinfo.cinformation";
                MySqlCommand mycom = new MySqlCommand(displayQuery, con);
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = mycom;
                DataTable dt = new DataTable();
                mda.Fill(dt);
                dataGridView1.DataSource = dt;
                
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
