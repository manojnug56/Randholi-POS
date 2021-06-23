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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        //Clear method
        private void ClearFields()
        {
            txt_userId.ResetText();
            txt_password.ResetText();

            txt_userId.Focus();
        }

        private bool dataValid()
        {
            if (txt_userId.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Please Enter Both UserID And Password!", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_userId.Focus();
                return false;
            }

            else if (txt_userId.Text == "")
            {
                MessageBox.Show("User Id Please!", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_userId.Focus();
                return false;
            }

            else if (txt_password.Text == "")
            {
                MessageBox.Show("Password Please!", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return false;
            }

            return true;
        }

        private void login()
        {
            if(dataValid())
            {
                
                User usr = new User();
                usr.userId = Convert.ToInt32(txt_userId.Text);
                usr.password = txt_password.Text;
                usr.selectUser(usr);
                ClearFields();
                this.Hide();
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            //Confirming for close the form
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //Using clear method
            ClearFields();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked == true)
            {
                txt_password.isPassword = false;
            }

            else if (chk_show.Checked == false)
            {
                txt_password.isPassword = true;
            }
        }

        private void txt_userId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void txt_userId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8 && chr != 13)
            {
                e.Handled = true;
                MessageBox.Show("You Must Enter Numeric Value For User Id Field!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_userId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
