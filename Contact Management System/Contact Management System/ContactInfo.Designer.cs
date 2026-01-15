namespace Contact_Management_System
{
    partial class ContactInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Type:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(123, 83);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(278, 26);
            this.txt_id.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(123, 134);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(278, 26);
            this.txt_name.TabIndex = 7;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(123, 296);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(278, 26);
            this.txt_address.TabIndex = 8;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(123, 188);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(278, 26);
            this.txt_phone.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(123, 242);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(278, 26);
            this.txt_email.TabIndex = 10;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(123, 346);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(278, 28);
            this.cmb_type.TabIndex = 11;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.Cmb_type_SelectedIndexChanged);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(19, 397);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(87, 35);
            this.bt_insert.TabIndex = 12;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.Bt_insert_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(142, 397);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(87, 35);
            this.bt_update.TabIndex = 13;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(259, 397);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(87, 35);
            this.bt_delete.TabIndex = 14;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(386, 397);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(87, 35);
            this.bt_clear.TabIndex = 15;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.Bt_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 307);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Information Management System";
            this.Load += new System.EventHandler(this.ContactInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

