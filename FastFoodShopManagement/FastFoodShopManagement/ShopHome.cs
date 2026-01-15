using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodShopManagement
{
    public partial class ShopHome : Form
    {
        public ShopHome()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rb_foodItem.ForeColor = System.Drawing.Color.Red;
            rb_drinks.ForeColor = System.Drawing.Color.Green;

            Com_ItemSelect.Items.Clear();
            Com_ItemSelect.Items.Add("Pizza");
            Com_ItemSelect.Items.Add("Burger");
            Com_ItemSelect.Items.Add("Sandwich");

        }

        private void Rb_drinks_CheckedChanged(object sender, EventArgs e)
        {
            rb_foodItem.ForeColor = System.Drawing.Color.Green;
            rb_drinks.ForeColor = System.Drawing.Color.Red;

            Com_ItemSelect.Items.Clear();
            Com_ItemSelect.Items.Add("7up");
            Com_ItemSelect.Items.Add("Pepsi");
            Com_ItemSelect.Items.Add("CocaCola");
            Com_ItemSelect.Items.Add("Fanta");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Com_ItemSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Com_ItemSelect.SelectedItem.ToString() == "Pizza")
            {
                text_Price.Text = "150";
            }
            else if (Com_ItemSelect.SelectedItem.ToString() == "Burger")
            {
                text_Price.Text = "100";
            }
            else if (Com_ItemSelect.SelectedItem.ToString() == "Sandwich")
            {
                text_Price.Text = "90";
            }
            else if (Com_ItemSelect.SelectedItem.ToString() == "7up")
            {
                text_Price.Text = "35";
            }
            else if (Com_ItemSelect.SelectedItem.ToString() == "Pepsi")
            {
                text_Price.Text = "25";
            }
            else if (Com_ItemSelect.SelectedItem.ToString() == "CocaCola")
            {
                text_Price.Text = "15";
            }
            else if (Com_ItemSelect.SelectedItem.ToString() == "Fanta")
            {
                text_Price.Text = "30";
            }
            else
            {
                text_Price.Text = "0";
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            txt_total.Text = (Convert.ToInt32(text_Price.Text) * Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void Bt_addItem_Click(object sender, EventArgs e)
        {
            string[] item = new string[4];
            item[0] = Com_ItemSelect.SelectedItem.ToString();
            item[1] = text_Price.Text;
            item[2] = textBox1.Text;
            item[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(item);
            listView1.Items.Add(lvi);

            txt_subtotal.Text = (Convert.ToInt32(txt_subtotal.Text)+Convert.ToInt32(txt_total.Text)).ToString();

            txt_netprice.Text = txt_subtotal.Text;

        }

        private void Text_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_subtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if(txt_discount.Text =="0")
            {
                txt_netprice.Text = txt_subtotal.Text;
            }
            else
            {
                txt_netprice.Text = (Convert.ToInt32(txt_subtotal.Text) - (Convert.ToInt32(txt_subtotal.Text) * Convert.ToInt32(txt_discount.Text) / 100)).ToString();
            }
        }
    }
}
