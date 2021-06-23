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
    public partial class frm_calculator : Form
    {
        public frm_calculator()
        {
            InitializeComponent();
            txt_itemQuantity.Focus();
        }

        string itemQuantity;
        public string Quantity
        {
            get { return itemQuantity; }
        }

        Label lbl = new Label();

        string input = string.Empty;
        public void close()
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 1;
            itemQuantity = txt_itemQuantity.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 9;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.Text += 0;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            int c = txt_itemQuantity.TextLength;
            int flag = 0;
            string text = txt_itemQuantity.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txt_itemQuantity.Text += ".";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_itemQuantity.ResetText();
            txt_itemQuantity.Focus();
        }

        private void btn_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)48)
            {
                txt_itemQuantity.Text += 0;
            }

            else if (e.KeyChar == (char)49)
            {
                txt_itemQuantity.Text += 1;
                
            }

            else if (e.KeyChar == (char)50)
            {
                txt_itemQuantity.Text += 2;
            }

            else if (e.KeyChar == (char)51)
            {
                txt_itemQuantity.Text += 3;
            }

            else if (e.KeyChar == (char)52)
            {
                txt_itemQuantity.Text += 4;
            }

            else if (e.KeyChar == (char)53)
            {
                txt_itemQuantity.Text += 5;
            }

            else if (e.KeyChar == (char)54)
            {
                txt_itemQuantity.Text += 6;
            }

            else if (e.KeyChar == (char)55)
            {
                txt_itemQuantity.Text += 7;
            }

            else if (e.KeyChar == (char)56)
            {
                txt_itemQuantity.Text += 8;
            }

            else if (e.KeyChar == (char)57)
            {
                txt_itemQuantity.Text += 9;
            }

            else if (e.KeyChar == (char)13)
            {
                close();
                itemQuantity = txt_itemQuantity.Text;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
