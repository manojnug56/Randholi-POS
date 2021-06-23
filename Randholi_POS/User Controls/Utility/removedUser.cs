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
    public partial class removedUser : UserControl
    {
        public removedUser()
        {
            InitializeComponent();
        }

        private void dataBind()
        {
            dtg_users.Columns[0].HeaderText = "No";
            dtg_users.Columns[1].HeaderText = "User ID";
            dtg_users.Columns[2].HeaderText = "First Name";
            dtg_users.Columns[3].HeaderText = "Last Name";
            dtg_users.Columns[4].HeaderText = "NIC";
            dtg_users.Columns[5].HeaderText = "Password";
            dtg_users.Columns[6].HeaderText = "User Type";
            dtg_users.Columns[7].HeaderText = "Gender";
            dtg_users.Columns[8].HeaderText = "Adress";
            dtg_users.Columns[9].HeaderText = "Contact/s";
            dtg_users.Columns[10].HeaderText = "Registered Date And Time";
            dtg_users.Columns[11].HeaderText = "Deleted Date And Time";

            dtg_users.Columns[0].Visible = false;
            dtg_users.Columns[5].Visible = false;
        }
        private void SearchName()
        {
            User emp = new User();
            string sql = ("SELECT * FROM tbl_del_user WHERE f_name LIKE '" + txt_searchName.Text + "%' ORDER BY f_name");
            dtg_users.DataSource = emp.getData(sql).Tables[0];
            dataBind();
        }

        private void SearchType()
        {
            User emp = new User();
            string sql = ("SELECT * FROM tbl_del_user WHERE user_type LIKE '" + txt_searchType.Text + "%' ORDER BY f_name");
            dtg_users.DataSource = emp.getData(sql).Tables[0];
            dataBind();
        }

        private void SearchNic()
        {
            User emp = new User();
            string sql = ("SELECT * FROM tbl_del_user WHERE nic LIKE '" + txt_searchNic.Text + "%' ORDER BY f_name");
            dtg_users.DataSource = emp.getData(sql).Tables[0];
            dataBind();
        }

        private void DataBindToGridView()
        {
            User emp = new User();
            string sql = "SELECT* FROM tbl_del_user";
            dtg_users.DataSource = emp.getData(sql).Tables[0];

            dtg_users.Columns[0].HeaderText = "No";
            dtg_users.Columns[1].HeaderText = "User ID";
            dtg_users.Columns[2].HeaderText = "First Name";
            dtg_users.Columns[3].HeaderText = "Last Name";
            dtg_users.Columns[4].HeaderText = "NIC";
            dtg_users.Columns[5].HeaderText = "Password";
            dtg_users.Columns[6].HeaderText = "User Type";
            dtg_users.Columns[7].HeaderText = "Gender";
            dtg_users.Columns[8].HeaderText = "Adress";
            dtg_users.Columns[9].HeaderText = "Contact/s";
            dtg_users.Columns[10].HeaderText = "Registered Date And Time";
            dtg_users.Columns[11].HeaderText = "Deleted Date And Time";
    
            dtg_users.Columns[5].Visible = false;

        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataBindToGridView();
        }

        private void txt_searchName_TextChanged(object sender, EventArgs e)
        {
            SearchName();
        }

        private void txt_searchType_TextChanged(object sender, EventArgs e)
        {
            SearchType();
        }

        private void txt_searchNic_TextChanged(object sender, EventArgs e)
        {
            SearchNic();
        }
    }
}
