namespace Randholi_POS
{
    partial class removedItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_searchCat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_searchName = new System.Windows.Forms.TextBox();
            this.dtg_removedItem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_removedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_searchCat);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_searchName);
            this.panel1.Controls.Add(this.dtg_removedItem);
            this.panel1.Location = new System.Drawing.Point(35, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 599);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(368, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Search By Category";
            // 
            // txt_searchCat
            // 
            this.txt_searchCat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_searchCat.Location = new System.Drawing.Point(499, 17);
            this.txt_searchCat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchCat.Multiline = true;
            this.txt_searchCat.Name = "txt_searchCat";
            this.txt_searchCat.Size = new System.Drawing.Size(210, 29);
            this.txt_searchCat.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(17, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Search By Name";
            // 
            // txt_searchName
            // 
            this.txt_searchName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_searchName.Location = new System.Drawing.Point(128, 17);
            this.txt_searchName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchName.Multiline = true;
            this.txt_searchName.Name = "txt_searchName";
            this.txt_searchName.Size = new System.Drawing.Size(210, 29);
            this.txt_searchName.TabIndex = 1;
            // 
            // dtg_removedItem
            // 
            this.dtg_removedItem.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtg_removedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_removedItem.Location = new System.Drawing.Point(20, 51);
            this.dtg_removedItem.Name = "dtg_removedItem";
            this.dtg_removedItem.Size = new System.Drawing.Size(1001, 525);
            this.dtg_removedItem.TabIndex = 0;
            // 
            // removedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Name = "removedItem";
            this.Size = new System.Drawing.Size(1113, 633);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_removedItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_searchCat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_searchName;
        private System.Windows.Forms.DataGridView dtg_removedItem;
    }
}
