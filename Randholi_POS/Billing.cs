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
    public partial class frm_billing : Form
    {
        public frm_billing()
        {
            InitializeComponent();

            timer1.Start();

            pnl_dining.Hide();
            pnl_takeAway.Hide();
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

        private void btn_takeAway_Click(object sender, EventArgs e)
        {
            pnl_takeAway.Show();
            pnl_dining.Hide();
        }

        private void btn_dining_Click(object sender, EventArgs e)
        {
            pnl_takeAway.Hide();
            pnl_dining.Show();
        }
    }
}
