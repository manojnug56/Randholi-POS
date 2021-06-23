namespace Randholi_POS
{
    partial class manageItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_itemId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtg_items = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rd_food = new System.Windows.Forms.RadioButton();
            this.rd_bar = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_itemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cusType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_iName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_items)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.lbl_itemId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtg_items);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Location = new System.Drawing.Point(35, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 341);
            this.panel1.TabIndex = 5;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(942, 24);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 98;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_itemId
            // 
            this.lbl_itemId.AutoSize = true;
            this.lbl_itemId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_itemId.Location = new System.Drawing.Point(843, 28);
            this.lbl_itemId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_itemId.Name = "lbl_itemId";
            this.lbl_itemId.Size = new System.Drawing.Size(0, 15);
            this.lbl_itemId.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(778, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 96;
            this.label11.Text = "Item ID -";
            // 
            // dtg_items
            // 
            this.dtg_items.AllowUserToAddRows = false;
            this.dtg_items.AllowUserToDeleteRows = false;
            this.dtg_items.AllowUserToResizeRows = false;
            this.dtg_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_items.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtg_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_items.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_items.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_items.EnableHeadersVisualStyles = false;
            this.dtg_items.Location = new System.Drawing.Point(16, 52);
            this.dtg_items.Name = "dtg_items";
            this.dtg_items.ReadOnly = true;
            this.dtg_items.RowHeadersVisible = false;
            this.dtg_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_items.Size = new System.Drawing.Size(1001, 270);
            this.dtg_items.TabIndex = 86;
            this.dtg_items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtg_items_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(17, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.Location = new System.Drawing.Point(177, 18);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(267, 29);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_DeleteUser);
            this.panel2.Controls.Add(this.btn_UpdateUser);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rd_food);
            this.panel2.Controls.Add(this.rd_bar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_itemType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_cusType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_sName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_iName);
            this.panel2.Location = new System.Drawing.Point(35, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 236);
            this.panel2.TabIndex = 6;
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteUser.BackgroundImage")));
            this.btn_DeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_DeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Location = new System.Drawing.Point(750, 170);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(126, 47);
            this.btn_DeleteUser.TabIndex = 87;
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_UpdateUser
            // 
            this.btn_UpdateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateUser.BackgroundImage")));
            this.btn_UpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateUser.FlatAppearance.BorderSize = 0;
            this.btn_UpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_UpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateUser.Location = new System.Drawing.Point(891, 170);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(126, 47);
            this.btn_UpdateUser.TabIndex = 86;
            this.btn_UpdateUser.UseVisualStyleBackColor = true;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price.Location = new System.Drawing.Point(750, 121);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(267, 29);
            this.txt_price.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(578, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Price";
            // 
            // rd_food
            // 
            this.rd_food.AutoSize = true;
            this.rd_food.Location = new System.Drawing.Point(270, 125);
            this.rd_food.Name = "rd_food";
            this.rd_food.Size = new System.Drawing.Size(49, 17);
            this.rd_food.TabIndex = 4;
            this.rd_food.TabStop = true;
            this.rd_food.Text = "Food";
            this.rd_food.UseVisualStyleBackColor = true;
            this.rd_food.CheckedChanged += new System.EventHandler(this.rd_food_CheckedChanged);
            // 
            // rd_bar
            // 
            this.rd_bar.AutoSize = true;
            this.rd_bar.Location = new System.Drawing.Point(175, 126);
            this.rd_bar.Name = "rd_bar";
            this.rd_bar.Size = new System.Drawing.Size(41, 17);
            this.rd_bar.TabIndex = 3;
            this.rd_bar.TabStop = true;
            this.rd_bar.Text = "Bar";
            this.rd_bar.UseVisualStyleBackColor = true;
            this.rd_bar.CheckedChanged += new System.EventHandler(this.rd_bar_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(578, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "Item Type";
            // 
            // cmb_itemType
            // 
            this.cmb_itemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemType.FormattingEnabled = true;
            this.cmb_itemType.Items.AddRange(new object[] {
            "Medium",
            "Large",
            "Regular",
            "1 L",
            "750 ML",
            "500 ML",
            "Half ",
            "100 ML",
            "50 ML",
            "25 ML"});
            this.cmb_itemType.Location = new System.Drawing.Point(750, 18);
            this.cmb_itemType.Name = "cmb_itemType";
            this.cmb_itemType.Size = new System.Drawing.Size(267, 28);
            this.cmb_itemType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(578, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Custom Type";
            // 
            // txt_cusType
            // 
            this.txt_cusType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cusType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cusType.Location = new System.Drawing.Point(750, 71);
            this.txt_cusType.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cusType.Multiline = true;
            this.txt_cusType.Name = "txt_cusType";
            this.txt_cusType.Size = new System.Drawing.Size(267, 29);
            this.txt_cusType.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Second Name";
            // 
            // txt_sName
            // 
            this.txt_sName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sName.Location = new System.Drawing.Point(175, 71);
            this.txt_sName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sName.Multiline = true;
            this.txt_sName.Name = "txt_sName";
            this.txt_sName.Size = new System.Drawing.Size(267, 29);
            this.txt_sName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Item Name";
            // 
            // txt_iName
            // 
            this.txt_iName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_iName.Location = new System.Drawing.Point(175, 20);
            this.txt_iName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_iName.Multiline = true;
            this.txt_iName.Name = "txt_iName";
            this.txt_iName.Size = new System.Drawing.Size(267, 29);
            this.txt_iName.TabIndex = 1;
            // 
            // manageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "manageItem";
            this.Size = new System.Drawing.Size(1113, 633);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_items)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rd_food;
        private System.Windows.Forms.RadioButton rd_bar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_itemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cusType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_iName;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.DataGridView dtg_items;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_itemId;
        private System.Windows.Forms.Label label11;
    }
}
