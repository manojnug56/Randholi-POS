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
    public partial class itemControl : UserControl
    {
        public itemControl()
        {
            InitializeComponent();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(DataValid())
            {
                Items itm = new Items();
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

                itm.saveItem(itm);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
