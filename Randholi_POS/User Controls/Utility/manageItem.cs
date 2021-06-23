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
    public partial class manageItem : UserControl
    {
        public manageItem()
        {
            InitializeComponent();
        }

        private void Search()
        {
            User emp = new User();
            string sql = ("SELECT * FROM tbl_item WHERE f_name LIKE '" + txt_search.Text + "%' ORDER BY f_name");
            dtg_items.DataSource = emp.getData(sql).Tables[0];

            dtg_items.Columns[0].HeaderText = "Item ID";
            dtg_items.Columns[1].HeaderText = "First Name";
            dtg_items.Columns[2].HeaderText = "Second Name";
            dtg_items.Columns[3].HeaderText = "Category";
            dtg_items.Columns[4].HeaderText = "Item Type";
            dtg_items.Columns[5].HeaderText = "Custome Type";
            dtg_items.Columns[6].HeaderText = "Price";
            dtg_items.Columns[7].HeaderText = "Registered Date And Time";
        }
        private void ClearFields()
        {
            txt_iName.ResetText();
            txt_sName.ResetText();
            rd_bar.Checked = false;
            rd_food.Checked = false;
            cmb_itemType.ResetText();
            txt_cusType.ResetText();
            txt_price.ResetText();
        }
        private void DataBindToGridView()
        {

            User emp = new User();
            string sql = "SELECT* FROM tbl_item";
            dtg_items.DataSource = emp.getData(sql).Tables[0];

            dtg_items.Columns[0].HeaderText = "Item ID";
            dtg_items.Columns[1].HeaderText = "First Name";
            dtg_items.Columns[2].HeaderText = "Second Name";
            dtg_items.Columns[3].HeaderText = "Category";
            dtg_items.Columns[4].HeaderText = "Item Type";
            dtg_items.Columns[5].HeaderText = "Custome Type";
            dtg_items.Columns[6].HeaderText = "Price";
            dtg_items.Columns[7].HeaderText = "Registered Date And Time";
        }
        private bool DataValid()
        {
            if (txt_iName.Text == "")
            {
                MessageBox.Show("Enter Item Name !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_iName.Focus();
                return false;
            }

            if (rd_bar.Checked == false && rd_food.Checked == false)
            {
                MessageBox.Show("Select An Item Category !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label6.Focus();
                return false;
            }

            if (cmb_itemType.Text == "" && txt_cusType.Text == "")
            {
                MessageBox.Show("Please Select An Item Type Or Define Custome Type !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_itemType.Focus();
                return false;
            }

            if (txt_price.Text == "")
            {
                MessageBox.Show("Enter The Price For Item !", "Missing Deatails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_price.Focus();
                return false;
            }

            return true;
        }
        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            if (DataValid())
            {
                Items itm = new Items();
                itm.itemId = Convert.ToInt32(lbl_itemId.Text);
                itm.firstName = txt_iName.Text;
                itm.secondName = txt_sName.Text;

                if (Type == "Bar")
                {
                    itm.category = rd_bar.Text;
                }

                if (Type == "Food")
                {
                    itm.category = rd_food.Text;
                }

                itm.itemType = cmb_itemType.Text;
                itm.customeType = txt_cusType.Text;
                itm.price = Convert.ToDecimal(txt_price.Text);

                itm.updateItem(itm);
                DataBindToGridView();
                ClearFields();
            }
        }

        string Type;
        private void rd_bar_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Bar";
        }

        private void rd_food_CheckedChanged(object sender, EventArgs e)
        {
            Type = "Food";
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DataBindToGridView();
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Delete This Admin ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Items itm = new Items();
                itm.itemId = Convert.ToInt32(lbl_itemId.Text);
                itm.deleteItem(itm);
                DataBindToGridView();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtg_items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dtg_items.SelectedRows)
            {
                lbl_itemId.Text = row.Cells[0].Value.ToString();
                txt_iName.Text = row.Cells[1].Value.ToString();
                txt_sName.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value.ToString() == "Bar")
                {
                    rd_bar.Checked = true;
                }

                if (row.Cells[3].Value.ToString() == "Food")
                {
                    rd_food.Checked = true;
                }

                cmb_itemType.Text = row.Cells[4].Value.ToString();
                txt_cusType.Text = row.Cells[5].Value.ToString();
                txt_price.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
