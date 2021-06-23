namespace Randholi_POS
{
    partial class manageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_users = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_userId = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_userType = new System.Windows.Forms.TextBox();
            this.chk_show2 = new System.Windows.Forms.CheckBox();
            this.chk_show1 = new System.Windows.Forms.CheckBox();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_UpdateUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.txt_adress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dtg_users);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.lbl_userId);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Location = new System.Drawing.Point(35, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 285);
            this.panel1.TabIndex = 2;
            // 
            // dtg_users
            // 
            this.dtg_users.AllowUserToAddRows = false;
            this.dtg_users.AllowUserToDeleteRows = false;
            this.dtg_users.AllowUserToResizeRows = false;
            this.dtg_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_users.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtg_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtg_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_users.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_users.EnableHeadersVisualStyles = false;
            this.dtg_users.Location = new System.Drawing.Point(20, 51);
            this.dtg_users.MultiSelect = false;
            this.dtg_users.Name = "dtg_users";
            this.dtg_users.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_users.RowHeadersVisible = false;
            this.dtg_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_users.Size = new System.Drawing.Size(1001, 219);
            this.dtg_users.TabIndex = 99;
            this.dtg_users.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtg_users_MouseDoubleClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.Location = new System.Drawing.Point(946, 22);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 98;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_userId
            // 
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_userId.Location = new System.Drawing.Point(859, 26);
            this.lbl_userId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(0, 15);
            this.lbl_userId.TabIndex = 97;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(796, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 96;
            this.label16.Text = "User ID -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(17, 20);
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
            this.txt_search.Location = new System.Drawing.Point(177, 17);
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
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_userType);
            this.panel2.Controls.Add(this.chk_show2);
            this.panel2.Controls.Add(this.chk_show1);
            this.panel2.Controls.Add(this.btn_DeleteUser);
            this.panel2.Controls.Add(this.btn_UpdateUser);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_rePassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_newPassword);
            this.panel2.Controls.Add(this.txt_adress);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rd_female);
            this.panel2.Controls.Add(this.rd_male);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_contact);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_nic);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_lName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_fName);
            this.panel2.Location = new System.Drawing.Point(35, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 293);
            this.panel2.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(635, 193);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 111;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(632, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 110;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(647, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 109;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(45, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 108;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(89, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 107;
            this.label11.Text = "*";
            // 
            // txt_userType
            // 
            this.txt_userType.Enabled = false;
            this.txt_userType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_userType.Location = new System.Drawing.Point(754, 12);
            this.txt_userType.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userType.Multiline = true;
            this.txt_userType.Name = "txt_userType";
            this.txt_userType.Size = new System.Drawing.Size(267, 29);
            this.txt_userType.TabIndex = 105;
            // 
            // chk_show2
            // 
            this.chk_show2.AutoSize = true;
            this.chk_show2.Location = new System.Drawing.Point(391, 195);
            this.chk_show2.Name = "chk_show2";
            this.chk_show2.Size = new System.Drawing.Size(53, 17);
            this.chk_show2.TabIndex = 8;
            this.chk_show2.Text = "Show";
            this.chk_show2.UseVisualStyleBackColor = true;
            this.chk_show2.CheckedChanged += new System.EventHandler(this.chk_show2_CheckedChanged);
            // 
            // chk_show1
            // 
            this.chk_show1.AutoSize = true;
            this.chk_show1.Location = new System.Drawing.Point(391, 150);
            this.chk_show1.Name = "chk_show1";
            this.chk_show1.Size = new System.Drawing.Size(53, 17);
            this.chk_show1.TabIndex = 6;
            this.chk_show1.Text = "Show";
            this.chk_show1.UseVisualStyleBackColor = true;
            this.chk_show1.CheckedChanged += new System.EventHandler(this.chk_show1_CheckedChanged);
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
            this.btn_DeleteUser.Location = new System.Drawing.Point(754, 234);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(126, 47);
            this.btn_DeleteUser.TabIndex = 15;
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
            this.btn_UpdateUser.Location = new System.Drawing.Point(895, 234);
            this.btn_UpdateUser.Name = "btn_UpdateUser";
            this.btn_UpdateUser.Size = new System.Drawing.Size(126, 47);
            this.btn_UpdateUser.TabIndex = 14;
            this.btn_UpdateUser.UseVisualStyleBackColor = true;
            this.btn_UpdateUser.Click += new System.EventHandler(this.btn_UpdateUser_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(17, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 104;
            this.label9.Text = "Confirm Password";
            // 
            // txt_rePassword
            // 
            this.txt_rePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rePassword.Location = new System.Drawing.Point(177, 190);
            this.txt_rePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_rePassword.Multiline = true;
            this.txt_rePassword.Name = "txt_rePassword";
            this.txt_rePassword.PasswordChar = '*';
            this.txt_rePassword.Size = new System.Drawing.Size(209, 29);
            this.txt_rePassword.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "New Password";
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_newPassword.Location = new System.Drawing.Point(177, 145);
            this.txt_newPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_newPassword.Multiline = true;
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PasswordChar = '*';
            this.txt_newPassword.Size = new System.Drawing.Size(209, 29);
            this.txt_newPassword.TabIndex = 5;
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(754, 100);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(267, 77);
            this.txt_adress.TabIndex = 12;
            this.txt_adress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(582, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Adress";
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(849, 58);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(59, 17);
            this.rd_female.TabIndex = 11;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "Female";
            this.rd_female.UseVisualStyleBackColor = true;
            this.rd_female.CheckedChanged += new System.EventHandler(this.rd_female_CheckedChanged);
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Location = new System.Drawing.Point(754, 59);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(48, 17);
            this.rd_male.TabIndex = 10;
            this.rd_male.TabStop = true;
            this.rd_male.Text = "Male";
            this.rd_male.UseVisualStyleBackColor = true;
            this.rd_male.CheckedChanged += new System.EventHandler(this.rd_male_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(582, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(582, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(582, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Contact";
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contact.Location = new System.Drawing.Point(754, 190);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(267, 29);
            this.txt_contact.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "NIC";
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nic.Location = new System.Drawing.Point(177, 100);
            this.txt_nic.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nic.Multiline = true;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(267, 29);
            this.txt_nic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Last Name";
            // 
            // txt_lName
            // 
            this.txt_lName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lName.Location = new System.Drawing.Point(177, 55);
            this.txt_lName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lName.Multiline = true;
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(267, 29);
            this.txt_lName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "First Name";
            // 
            // txt_fName
            // 
            this.txt_fName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_fName.Location = new System.Drawing.Point(177, 12);
            this.txt_fName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fName.Multiline = true;
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(267, 29);
            this.txt_fName.TabIndex = 2;
            // 
            // manageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "manageUser";
            this.Size = new System.Drawing.Size(1113, 633);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_UpdateUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_rePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.RichTextBox txt_adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.CheckBox chk_show2;
        private System.Windows.Forms.CheckBox chk_show1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_userType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_userId;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dtg_users;
    }
}
