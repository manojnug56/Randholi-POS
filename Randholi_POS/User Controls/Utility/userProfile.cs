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
    public partial class userProfile : UserControl
    {
        public userProfile()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txt_fName.ResetText();
            txt_lName.ResetText();
            txt_nic.ResetText();
            txt_password.ResetText();
            txt_rePassword.ResetText();
            cmb_userType.ResetText();
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

            if (txt_password.Text == "")
            {
                MessageBox.Show("Enter New Password !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return false;
            }

            if (txt_rePassword.Text == "")
            {
                MessageBox.Show("Confirm Password !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_rePassword.Focus();
                return false;
            }

            if (txt_rePassword.Text != txt_password.Text)
            {
                MessageBox.Show("Password Doesn't Match !", "Un-Matched", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_rePassword.Focus();
                return false;
            }

            if (cmb_userType.Text == "")
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

            if (txt_password.Text.Length < 6)
            {
                MessageBox.Show("The Minimum character allowed for password is '6'", "Overload", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return false;
            }

            return true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            // insert data to the database
            if (DataValid())
            {
                User usr = new User();
                usr.firstName = txt_fName.Text;
                usr.lastName = txt_lName.Text;
                usr.nic = txt_nic.Text;
                usr.password = txt_password.Text;
                usr.userType = cmb_userType.Text;

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

                usr.saveUser(usr);
                DataBindToGridView();
                ClearFields();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void chk_show1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show1.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }

            else if (chk_show1.Checked == false)
            {
                txt_password.PasswordChar = '*';
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
    }
    
}
