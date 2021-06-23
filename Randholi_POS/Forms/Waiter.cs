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
    public partial class frm_waiter : Form
    {
        public frm_waiter()
        {
            InitializeComponent();
        }

        string orderType;
        public string Order
        {
            get { return orderType; }
        }

        public void close()
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_takeAway_DoubleClick(object sender, EventArgs e)
        {
            close();

            orderType = btn_takeAway.Text;
        }

        private void btn_din_DoubleClick(object sender, EventArgs e)
        {
            close();
            orderType = btn_din.Text;
        }
    }
}
