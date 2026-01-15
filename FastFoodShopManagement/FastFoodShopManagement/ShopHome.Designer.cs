namespace FastFoodShopManagement
{
    partial class ShopHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rb_foodItem = new System.Windows.Forms.RadioButton();
            this.rb_drinks = new System.Windows.Forms.RadioButton();
            this.Com_ItemSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.bt_addItem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_netprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastFoodShopManagement.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(262, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rb_foodItem
            // 
            this.rb_foodItem.AutoSize = true;
            this.rb_foodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_foodItem.Location = new System.Drawing.Point(239, 215);
            this.rb_foodItem.Name = "rb_foodItem";
            this.rb_foodItem.Size = new System.Drawing.Size(122, 28);
            this.rb_foodItem.TabIndex = 1;
            this.rb_foodItem.Text = "Food Item";
            this.rb_foodItem.UseVisualStyleBackColor = true;
            this.rb_foodItem.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rb_drinks
            // 
            this.rb_drinks.AutoSize = true;
            this.rb_drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_drinks.Location = new System.Drawing.Point(457, 215);
            this.rb_drinks.Name = "rb_drinks";
            this.rb_drinks.Size = new System.Drawing.Size(86, 28);
            this.rb_drinks.TabIndex = 1;
            this.rb_drinks.Text = "Drinks";
            this.rb_drinks.UseVisualStyleBackColor = true;
            this.rb_drinks.CheckedChanged += new System.EventHandler(this.Rb_drinks_CheckedChanged);
            // 
            // Com_ItemSelect
            // 
            this.Com_ItemSelect.FormattingEnabled = true;
            this.Com_ItemSelect.Location = new System.Drawing.Point(239, 262);
            this.Com_ItemSelect.Name = "Com_ItemSelect";
            this.Com_ItemSelect.Size = new System.Drawing.Size(281, 21);
            this.Com_ItemSelect.TabIndex = 2;
            this.Com_ItemSelect.SelectedIndexChanged += new System.EventHandler(this.Com_ItemSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // text_Price
            // 
            this.text_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Price.Location = new System.Drawing.Point(144, 315);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(100, 26);
            this.text_Price.TabIndex = 5;
            this.text_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(356, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            this.label4.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(531, 311);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 26);
            this.txt_total.TabIndex = 5;
            this.txt_total.TextChanged += new System.EventHandler(this.Text_total_TextChanged);
            // 
            // bt_addItem
            // 
            this.bt_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addItem.Location = new System.Drawing.Point(321, 356);
            this.bt_addItem.Name = "bt_addItem";
            this.bt_addItem.Size = new System.Drawing.Size(103, 40);
            this.bt_addItem.TabIndex = 6;
            this.bt_addItem.Text = "Add Item";
            this.bt_addItem.UseVisualStyleBackColor = true;
            this.bt_addItem.Click += new System.EventHandler(this.Bt_addItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Unit_Price,
            this.Quantity,
            this.Total});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 402);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 175);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 150;
            // 
            // Unit_Price
            // 
            this.Unit_Price.Text = "Unit Price";
            this.Unit_Price.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 100;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sub Total:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(74, 597);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 9;
            this.txt_subtotal.Text = "0";
            this.txt_subtotal.TextChanged += new System.EventHandler(this.Txt_subtotal_TextChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(271, 597);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 20);
            this.txt_discount.TabIndex = 11;
            this.txt_discount.Text = "0";
            this.txt_discount.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discount (%):";
            // 
            // txt_netprice
            // 
            this.txt_netprice.Location = new System.Drawing.Point(477, 597);
            this.txt_netprice.Name = "txt_netprice";
            this.txt_netprice.Size = new System.Drawing.Size(100, 20);
            this.txt_netprice.TabIndex = 13;
            this.txt_netprice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Net Price:";
            // 
            // ShopHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 648);
            this.Controls.Add(this.txt_netprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_addItem);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Com_ItemSelect);
            this.Controls.Add(this.rb_drinks);
            this.Controls.Add(this.rb_foodItem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShopHome";
            this.Text = "Fast Food Shop Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_foodItem;
        private System.Windows.Forms.RadioButton rb_drinks;
        private System.Windows.Forms.ComboBox Com_ItemSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button bt_addItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Unit_Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_netprice;
        private System.Windows.Forms.Label label7;
    }
}

