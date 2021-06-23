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
    public partial class frm_utility : Form
    {
        public frm_utility()
        {
            InitializeComponent();

            HideNavBar();
            nav1.Show();
            home1.BringToFront();
            timer1.Start();
        }

        private void HideNavBar()
        {
            nav1.Hide();
            nav2.Hide();
            nav3.Hide();
            nav4.Hide();
            nav5.Hide();
            nav6.Hide();
            nav7.Hide();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtm = DateTime.Now;
            this.lbl_date.Text = dtm.ToString();
        }
        private void btn_userProfile_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav1.Show();

            userProfile1.BringToFront();
        }
        private void btn_manageUser_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav2.Show();

            manageUser1.BringToFront();
        }
        private void btn_itemControl_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav3.Show();

            itemControl1.BringToFront();
        }
        private void btn_manageItem_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav4.Show();

            manageItem1.BringToFront();
        }
        private void btn_adminProfile_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav5.Show();

            adminProfile1.BringToFront();

           
        }
        private void btn_manageAdmin_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav6.Show();

            manageAdmin1.BringToFront();
        }
        private void btn_removedUser_Click(object sender, EventArgs e)
        {
            HideNavBar();
            nav7.Show();

            removedUser1.BringToFront();
        }
    }
}
