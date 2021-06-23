using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randholi_POS
{
    public partial class manageUser : UserControl
    {
        public manageUser()
        {
            InitializeComponent();
        }

        private void Search()
        {
            User emp = new User();
            string sql = ("SELECT * FROM tbl_user WHERE f_name LIKE '" + txt_search.Text + "%' ORDER BY f_name");
            dtg_users.DataSource = emp.getData(sql).Tables[0];

            dtg_users.Columns[0].HeaderText = "User ID";
            dtg_users.Columns[1].HeaderText = "First Name";
            dtg_users.Columns[2].HeaderText = "Last Name";
            dtg_users.Columns[3].HeaderText = "NIC";
            dtg_users.Columns[4].HeaderText = "Password";
            dtg_users.Columns[5].HeaderText = "User Type";
            dtg_users.Columns[6].HeaderText = "Gender";
            dtg_users.Columns[7].HeaderText = "Adress";
            dtg_users.Columns[8].HeaderText = "Contact/s";
            dtg_users.Columns[9].HeaderText = "Registered Date And Time";

            dtg_users.Columns[4].Visible = false;
        }
        private void ClearFields()
        {
            txt_fName.ResetText();
            txt_lName.ResetText();
            txt_nic.ResetText();
            txt_newPassword.ResetText();
            txt_rePassword.ResetText();
            txt_userType.ResetText();
            rd_male.Checked = false;
            rd_female.Checked = false;
            txt_adress.ResetText();
            txt_contact.ResetText();
        }
        private void DataBindToGridView()
        {

            User emp = new User();
            string sql = "SELECT* FROM tbl_user WHERE user_type = 'Manager' OR user_type = 'Accountant' OR user_type = 'Cashier' ";
            dtg_users.DataSource = emp.getData(sql).Tables[0];

            dtg_users.Columns[0].HeaderText = "User ID";
            dtg_users.Columns[1].HeaderText = "First Name";
            dtg_users.Columns[2].HeaderText = "Last Name";
            dtg_users.Columns[3].HeaderText = "NIC";
            dtg_users.Columns[4].HeaderText = "Password";
            dtg_users.Columns[5].HeaderText = "User Type";
            dtg_users.Columns[6].HeaderText = "Gender";
            dtg_users.Columns[7].HeaderText = "Adress";
            dtg_users.Columns[8].HeaderText = "Contact/s";
            dtg_users.Columns[9].HeaderText = "Registered Date And Time";

            dtg_users.Columns[4].Visible = false;

        }

        private bool DataValid()
        {
            if (txt_fName.Text == "")
            {
                MessageBox.Show("Enter First Name !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fName.Focus();
                return false;
            }

            if (txt_nic.Text == "")
            {
                MessageBox.Show("Enter NIC !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nic.Focus();
                return false;
            }

            if (txt_rePassword.Text != txt_newPassword.Text)
            {
                MessageBox.Show("Password Doesn't Match !", "Un-Matched", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_rePassword.Focus();
                return false;
            }

            if (txt_userType.Text == "")
            {
                MessageBox.Show("Select User Type !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rd_male.Checked == false && rd_female.Checked == false)
            {
                MessageBox.Show("Select Gender of user !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_contact.Text == "")
            {
                MessageBox.Show("Enter Contact/s !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_contact.Focus();
                return false;
            }

            if (txt_newPassword.Text != "")
            {
                if (txt_newPassword.Text.Length < 6)
                {
                    MessageBox.Show("The Minimum character allowed for password is '6'", "Overload", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_newPassword.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                User usr = new User();
                usr.userId = Convert.ToInt32(lbl_userId.Text);
                usr.firstName = txt_fName.Text;
                usr.lastName = txt_lName.Text;
                usr.nic = txt_nic.Text;
                usr.password = txt_newPassword.Text;

                if (Type == "Male")
                {
                    usr.gender = rd_male.Text;
                }

                if (Type == "Female")
                {
                    usr.gender = rd_female.Text;
                }

                usr.contact = txt_contact.Text;
                usr.adress = txt_adress.Text;

                usr.updateUser(usr);
                DataBindToGridView();
                ClearFields();
            }
        }
        private void chk_show1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show1.Checked == true)
            {
                txt_newPassword.PasswordChar = '\0';
            }

            else if (chk_show1.Checked == false)
            {
                txt_newPassword.PasswordChar = '*';
            }
        }

        private void chk_show2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show2.Checked == true)
            {
                txt_rePassword.PasswordChar = '\0';
            }

            else if (chk_show2.Checked == false)
            {
                txt_rePassword.PasswordChar = '*';
            }
        }

        string Type;
        private void rd_male_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Male";
        }

        private void rd_female_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Female";
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Delete This User ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                User usr = new User();
                usr.userId = Convert.ToInt32(lbl_userId.Text);
                usr.deleteUser(usr);
                DataBindToGridView();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataBindToGridView();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtg_users_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dtg_users.SelectedRows)
            {
                lbl_userId.Text = row.Cells[0].Value.ToString();
                txt_fName.Text = row.Cells[1].Value.ToString();
                txt_lName.Text = row.Cells[2].Value.ToString();
                txt_nic.Text = row.Cells[3].Value.ToString();
                txt_userType.Text = row.Cells[5].Value.ToString();

                if (row.Cells[6].Value.ToString() == "Male")
                {
                    rd_male.Checked = true;
                }

                if (row.Cells[6].Value.ToString() == "Female")
                {
                    rd_female.Checked = true;
                }

                txt_adress.Text = row.Cells[7].Value.ToString();
                txt_contact.Text = row.Cells[8].Value.ToString();
            }
        }
    }
}
