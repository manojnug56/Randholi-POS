using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Randholi_POS
{
    public partial class frm_order : Form
    {
        public frm_order()
        {
            InitializeComponent();

            tableArrange();

            if (cmb_waiterName.Text == "")
            {
                pnl_dining.Enabled = false;
                pnl_dining2.Enabled = false;
            }

            if (cmb_waiterName.Text != "")
            {
                pnl_dining.Enabled = true;
                pnl_dining2.Enabled = true;
            }

            DataBindToComboBox();
        }

        string tableName;
        string waiterName;
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        public string Table
        {
            get { return tableName; }
        }

        public string Waiter
        {
            get { return waiterName; }
        }

        // Data bind to combo box
        private void DataBindToComboBox()
        {
            try
            {
                Items emp = new Items();
                string sql = " SELECT * FROM tbl_waiter ";
                cmb_waiterName.DataSource = emp.getData(sql).Tables[0];

                cmb_waiterName.DisplayMember = "name";
                cmb_waiterName.ValueMember = "name";
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Table arrange
        public void tableArrange()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM  tbl_order_master  ", cs);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        if (dt.Rows[i][3].ToString() == "1" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl1.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "2" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl2.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "3" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl3.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "4" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl4.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "5" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl5.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "6" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl6.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "7" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl7.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "8" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl8.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "9" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl9.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "10" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl10.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "11" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl11.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "12" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl12.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "13" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl13.Hide();
                        }

                        else if (dt.Rows[i][3].ToString() == "14" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl14.Hide();
                        }          
                    }
                }

                else
                {
                    btn_tbl1.Show();
                    btn_tbl2.Show();
                    btn_tbl3.Show();
                    btn_tbl4.Show();
                    btn_tbl5.Show();
                    btn_tbl6.Show();
                    btn_tbl7.Show();
                    btn_tbl8.Show();
                    btn_tbl9.Show();
                    btn_tbl10.Show();
                    btn_tbl11.Show();
                    btn_tbl12.Show();
                    btn_tbl13.Show();
                    btn_tbl14.Show();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void close()
        {
            this.Close();
            DialogResult = DialogResult.OK;

            frm_waiter frm = new frm_waiter();
        }
        private void cmb_waiterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_waiterName.Text == "")
            {
                pnl_dining.Enabled = false;
                pnl_dining2.Enabled = false;
            }

            if (cmb_waiterName.Text != "")
            {
                pnl_dining.Enabled = true;
                pnl_dining2.Enabled = true;
            }
        }

        private void btn_tbl1_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "1";
            waiterName = cmb_waiterName.Text;
        }
        private void btn_tbl10_DoubleClick_1(object sender, EventArgs e)
        {
            close();
            tableName = "10";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl2_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "2";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl3_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "3";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl4_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "4";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl5_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "5";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl6_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "6";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl7_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "7";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl8_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "8";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl9_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "9";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl11_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "11";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl12_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "12";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl13_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "13";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_tbl14_DoubleClick(object sender, EventArgs e)
        {
            close();
            tableName = "14";
            waiterName = cmb_waiterName.Text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

