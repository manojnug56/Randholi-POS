using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randholi_POS
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();

            timer1.Start();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Confirming for close the form
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frm_login frm = new frm_login();
                frm.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtm = DateTime.Now;
            this.lbl_date.Text = dtm.ToString();
        }

        
        private void btn_utility_Click(object sender, EventArgs e)
        {
            frm_utility frm = new frm_utility();
            frm.lbl_role.Text = lbl_role.Text;
            frm.Show();

            if (lbl_role.Text == "Manager")
            {
                frm.btn_adminProfile.Hide();
                frm.btn_manageAdmin.Hide();
                frm.btn_removedUser.Hide();
            }
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            frm_billing frm = new frm_billing();
            frm.lbl_role.Text = lbl_role.Text;
            frm.txt_userId.Text = lbl_userId.Text;
            frm.txt_userName.Text = lbl_userName.Text;
            frm.Show();
        }
    }
}
