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
using CrystalDecisions.CrystalReports.Engine;

namespace Randholi_POS
{
 
    public partial class frm_billing : Form
    {
        private static bool exists;
        public frm_billing()
        {
            exists = false;
            InitializeComponent();

            timer1.Start();
            DataBindToComboBox();
            tableArrange();

            loadTakeAway();
            dt = new DataTable();
        }

        List<Orders> invlist = new List<Orders>();
        private static int i;


        // Sql connection
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        // Create Invoice Oorder List
        public int CreateOrderList()
        {
            for (int i = 0; i < dtg_orders.Rows.Count - 1; ++i)
            {
                Orders odr = new Orders();

                odr.ItemCode = Convert.ToInt32(dtg_orders.Rows[i].Cells[0].Value);
                odr.Quantity = Convert.ToInt32(dtg_orders.Rows[i].Cells[2].Value);
                odr.Price = Convert.ToDecimal(dtg_orders.Rows[i].Cells[3].Value);
                odr.Amount = Convert.ToDecimal(dtg_orders.Rows[i].Cells[4].Value);
                odr.kotBotStatus = dtg_orders.Rows[i].Cells[5].Value.ToString();

                invlist.Add(odr);
            }

            Orders odr2 = new Orders();
            int InvNo = odr2.SaveOrderRec(invlist);

            return InvNo;
        }

        // Add to datagridview
        private void addtoGridview()
        {
            using (frm_calculator frm = new frm_calculator())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Boolean to check if he has row has been
                    bool Found = false;
                    if (dtg_orders.Rows.Count > 0)
                    {
                        // Check if the product Id exists
                        foreach (DataGridViewRow row1 in dtg_orders.Rows)
                        {
                            if (Convert.ToString(row1.Cells[0].Value) == cmb_itemCode.Text)
                            {
                                // Update the Quantity of the found row
                                row1.Cells[2].Value = Convert.ToString(Convert.ToDecimal(frm.Quantity) + Convert.ToDecimal(row1.Cells[2].Value));
                                row1.Cells[4].Value = Convert.ToDecimal(Convert.ToDecimal(frm.Quantity) * Convert.ToDecimal(txt_price.Text) + Convert.ToDecimal(row1.Cells[4].Value));
                                FindTotal();
                                cmb_itemCode.Focus();

                                Found = true;
                            }
                        }

                        if (!Found)
                        {
                            // Add the row to grid view
                            if (exists == true)
                            {
                                dt = dtg_orders.DataSource as DataTable;
                                DataRow nrow = dt.NewRow();
                                dt.Rows.Add(nrow);
                                dtg_orders.DataSource = dt;
                            }
                            else {
                                dtg_orders.Rows.Add();
                            }


                            int row;
                            row = dtg_orders.Rows.Count - 2;

                            

                            dtg_orders[0, row].Value = cmb_itemCode.Text;
                            dtg_orders[1, row].Value = txt_item.Text;
                            dtg_orders[2, row].Value = frm.Quantity;
                            dtg_orders[3, row].Value = Convert.ToDecimal(txt_price.Text);
                            dtg_orders[4, row].Value = Convert.ToDecimal(frm.Quantity) * Convert.ToDecimal(txt_price.Text);
                            dtg_orders[5, row].Value = "N";

                            FindTotal();
                            cmb_itemCode.Focus();
                        }
                    }
                }
            }
        }

        // Table Arrange
        public void tableArrange()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(" SELECT * FROM  tbl_order_master ", cs);
                DataTable dt = new DataTable(); // This is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        if (dt.Rows[i][3].ToString() == "1" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl1.Normalcolor = Color.Brown;
                            btn_tbl1.OnHovercolor = Color.SaddleBrown;
                        }

                        if (dt.Rows[i][3].ToString() == "2" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl2.Normalcolor = Color.Brown;
                            btn_tbl2.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "3" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl3.Normalcolor = Color.Brown;
                            btn_tbl3.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "4" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl4.Normalcolor = Color.Brown;
                            btn_tbl4.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "5" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl5.Normalcolor = Color.Brown;
                            btn_tbl5.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "6" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl6.Normalcolor = Color.Brown;
                            btn_tbl6.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "7" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl7.Normalcolor = Color.Brown;
                            btn_tbl7.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "8" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl8.Normalcolor = Color.Brown;
                            btn_tbl8.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "9" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl9.Normalcolor = Color.Brown;
                            btn_tbl9.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "10" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl10.Normalcolor = Color.Brown;
                            btn_tbl10.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "11" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl11.Normalcolor = Color.Brown;
                            btn_tbl11.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "12" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl12.Normalcolor = Color.Brown;
                            btn_tbl12.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "13" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl13.Normalcolor = Color.Brown;
                            btn_tbl13.OnHovercolor = Color.SaddleBrown;
                        }

                        else if (dt.Rows[i][3].ToString() == "14" && dt.Rows[i][4].ToString() == "P")
                        {
                            btn_tbl14.Normalcolor = Color.Brown;
                            btn_tbl14.OnHovercolor = Color.SaddleBrown;
                        }
                    }
                }

                else
                {
                    btn_tbl1.reset();
                    btn_tbl2.Show();
                    btn_tbl3.Show();
                    btn_tbl4.Show();
                    btn_tbl5.Show();
                    btn_tbl6.Show();
                    btn_tbl7.Show();
                    btn_tbl8.Show();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clear All Fields
        private void clearFields()
        {
            txt_orderNumber.ResetText();
            txt_table.ResetText();
            txt_waiter.ResetText();
            txt_orderType.ResetText();

            txt_Amount.ResetText();
            txt_serviceCharge.ResetText();
            txt_grossAmount.ResetText();


            /* foreach (DataGridViewRow row in dtg_orders.SelectedRows)
             {
                 if (row.Selected == true)
                 {
                     dtg_orders.Rows.RemoveAt(row.Index);
                 }
             }*/
            //if (dtg_orders.Rows.Count > 0)
            // {
            //dtg_orders.Rows.Clear();
            // }
            //if (dtg_orders.ColumnCount > 0)
            // {

            /* dtg_orders.Columns.Add("Item Code", "Item Code");
             dtg_orders.Columns.Add("Item Name", "Item Name");
             dtg_orders.Columns.Add("Quantity", "Quantity");
             dtg_orders.Columns.Add("Price", "Price");
             dtg_orders.Columns.Add("Amount", "Amount");
             dtg_orders.Columns.Add("Amount", "Amount");*/
            dtg_orders.DataSource = null;
            dtg_orders.Refresh();
        }

        //Validate Data
        private bool dataValid()
        {
            if (txt_orderNumber.Text == "")
            {
                return false;
            }
            if (txt_table.Text == "")
            {
                return false;
            }
            if (txt_waiter.Text == "")
            {
                return false;
            }
            if (txt_orderType.Text == "")
            {
                return false;
            }
            if (txt_Amount.Text == "")
            {
                return false;
            }
            if (txt_serviceCharge.Text == "")
            {
                return false;
            }
            if (txt_grossAmount.Text == "")
            {
                return false;
            }

            return true;
        }

        // Load data to combo box
        private void DataBindToComboBox()
        {
            try
            {
                Items emp = new Items();
                string sql = " SELECT * FROM tbl_item ";
                cmb_itemCode.DataSource = emp.getData(sql).Tables[0];

                cmb_itemCode.DisplayMember = "id";
                cmb_itemCode.ValueMember = "f_name";
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Data bind to textbox and virtual text box
        TextBox txt_price = new TextBox();
        private void DataBindToTexBox()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string sql1 = " SELECT * FROM tbl_item WHERE CAST(id AS VARCHAR(20)) = '" + cmb_itemCode.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    decimal price = dr.GetDecimal(6);

                    txt_item.Text = name;
                    txt_price.Text = price.ToString();
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // get waiter id to virtual text box
        TextBox txt_waiterId = new TextBox();
        private void DataBindToTexBox1()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string sql1 = " SELECT * FROM tbl_waiter WHERE name = '" + txt_waiter.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    txt_waiterId.Text = id.ToString();
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Order Number Generate
        private void orderNumber()
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(" SELECT MAX(order_no) FROM  tbl_order_master ", cs);
                DataTable dt = new DataTable(); // This is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    i = Convert.ToInt32(dt.Rows[0][0]);
                    i++;
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            txt_orderNumber.Text = i.ToString();
        }

        // Load Order Part 1 
        private void LoadOrderDetails(int orderNumber, int tableNumber)
        {
            try
            {
                User odr = new User();
                string sql = ("SELECT OM.order_no, OM.table_no, OM.user_id, W.name FROM (tbl_order_master OM INNER JOIN tbl_waiter W ON OM.waiter_id = W.id) INNER JOIN tbl_user U ON OM.user_id = U.id WHERE table_no = '" + tableNumber + "' AND status = 'P' ");
                dt = null;
                dt= odr.getData(sql).Tables[0];
                //dtg_orders.DataSource = dt;

                

                if (dt.Rows.Count > 0)
                {
                    exists = true;
                    //dtg_orders.Columns[0].HeaderText = "";
                    //dtg_orders.Columns[1].HeaderText = "";
                    //dtg_orders.Columns[2].HeaderText = "";
                    //dtg_orders.Columns[3].HeaderText = "";

                    txt_orderNumber.Text = dt.Rows[0][0].ToString();
                    txt_table.Text = dt.Rows[0][1].ToString();
                    txt_userId.Text = dt.Rows[0][2].ToString();
                    txt_waiter.Text = dt.Rows[0][3].ToString();
                    txt_orderType.Text = "Dining";

                    //dtg_orders.Hide();
                    //dtg_orders.Show();
                }

                //else if (dtg_orders.Rows.Count == 0)
                //{
                //    dtg_orders.Columns[0].HeaderText = "Empty Table";
                //    dtg_orders.Columns[1].HeaderText = "Empty Table";
                //    dtg_orders.Columns[2].HeaderText = "Empty Table";
                //    dtg_orders.Columns[3].HeaderText = "Empty Table";
                //}
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        // Load Order Part 2 
        private void LoadOrderDetails1(int orderNumber, int tableNumber)
        {
           // if ()
            try
            {
                User odr = new User();
                dtg_orders.DataSource = null;
                dtg_orders.Refresh();
                string sql = ("SELECT OI.item_code AS [Item Code], I.f_name AS [Item Name], OI.quantity AS [Quantity], OI.price AS [Price], OI.amount AS [Amount], OI.status AS [Status]  FROM tbl_order_item OI INNER JOIN tbl_item I ON OI.item_code = I.id WHERE OI.order_no = '" + orderNumber + "' ");
                dtg_orders.DataSource = odr.getData(sql).Tables[0];

                /*dtg_orders.Columns[0].HeaderText = "Item Code";
                dtg_orders.Columns[1].HeaderText = "Item Name";
                dtg_orders.Columns[2].HeaderText = "Quantity";
                dtg_orders.Columns[3].HeaderText = "Price";
                dtg_orders.Columns[4].HeaderText = "Amount";
                dtg_orders.Columns[5].HeaderText = "Status";*/

                dtg_orders.Columns[5].Visible = false;

                FindTotal1();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // Load Take Away Order
        private void loadTakeAway()
        {
            try
            {
                User odr = new User();
                string sql = ("SELECT OM.order_no, OM.table_no, OM.user_id, W.name FROM (tbl_order_master OM INNER JOIN tbl_waiter W ON OM.waiter_id = W.id) INNER JOIN tbl_user U ON OM.user_id = U.id WHERE table_no = '0' AND status = 'P' ");
                dtg_TA.DataSource = odr.getData(sql).Tables[0];

                if (dtg_TA.Rows.Count > 0)
                {
                    dtg_TA.Columns[0].HeaderText = "Take-Away";
                    dtg_TA.Columns[1].HeaderText = "";
                    dtg_TA.Columns[2].HeaderText = "";
                    dtg_TA.Columns[3].HeaderText = "";

                    dtg_TA.Columns[1].Visible = false;
                    dtg_TA.Columns[2].Visible = false;
                    dtg_TA.Columns[3].Visible = false;

                    dtg_TA.RowTemplate.Height = 100;
                }

                else
                {
                    //dtg_orders.Columns[0].HeaderText = "Empty";
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Calculations 1
        private void FindTotal()
        {
            int sum = 0;
            int serviceChrg = 0;
            int tot = 0;

            for (int i = 0; i < dtg_orders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dtg_orders.Rows[i].Cells[4].Value);
            }
            txt_Amount.Text = sum.ToString("###,###.00");

            if (txt_orderType.Text == "Dining")
            {
                serviceChrg = sum / 10;
                txt_serviceCharge.Text = serviceChrg.ToString("###,###.00");
            }

            else if (txt_orderType.Text == "Take Away")
            {
                serviceChrg = 0;
                txt_serviceCharge.Text = serviceChrg.ToString("###,###.00");
            }

            tot = sum + serviceChrg;
            txt_grossAmount.Text = tot.ToString("###,###.00");
        }

        // Calculations 2
        private void FindTotal1()
        {
            int sum = 0;
            int serviceChrg = 0;
            int tot = 0;

            for (int i = 0; i < dtg_orders.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dtg_orders.Rows[i].Cells[4].Value);
            }
            txt_Amount.Text = sum.ToString("###,###.00");

            if (txt_orderType.Text == "Dining")
            {
                serviceChrg = sum / 10;
                txt_serviceCharge.Text = serviceChrg.ToString("###,###.00");
            }

            else if (txt_orderType.Text == "Take Away")
            {
                serviceChrg = 0;
                txt_serviceCharge.Text = serviceChrg.ToString("###,###.00");
            }

            tot = sum + serviceChrg;
            txt_grossAmount.Text = tot.ToString("###,###.00");
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Get current date and time
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtm = DateTime.Now;
            this.lbl_date.Text = dtm.ToString();
        }

        private void btn_takeAway_Click(object sender, EventArgs e)
        {
            loadTakeAway();
        }

        private void btn_dining_Click(object sender, EventArgs e)
        {
            pnl_dining.Show();
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            clearFields();
            tableArrange();

            dtg_orders.Columns.Add("Item Code", "Item Code");
            dtg_orders.Columns.Add("Item Name", "Item Name");
            dtg_orders.Columns.Add("Quantity", "Quantity");
            dtg_orders.Columns.Add("Price", "Price");
            dtg_orders.Columns.Add("Amount", "Amount");
            dtg_orders.Columns.Add("Status", "Status");

            using (frm_waiter frm = new frm_waiter())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txt_orderType.Text = frm.Order;
                    txt_table.Text = "0";
                    txt_waiter.Text = "User";
                    orderNumber();
                }
            }

            if (txt_orderType.Text != "Take Away" && txt_orderType.Text != "")
            {
                using (frm_order frm = new frm_order())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txt_table.Text = frm.Table;
                        txt_waiter.Text = frm.Waiter;

                        pnl_dining.Show();
                        orderNumber();
                    }
                }
            }
        }

        private void cmb_itemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txt_orderType.Text == "Dining")
                {
                    if (txt_table.Text == "")
                    {
                        MessageBox.Show("Please Select A Table !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if ( txt_waiter.Text == "" )
                    {
                        MessageBox.Show("Waiter Is Required !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        addtoGridview();
                    }
                }

                else if (txt_orderType.Text == "Take Away")
                {
                    addtoGridview();
                }
                else
                {
                    MessageBox.Show("Please Select Order Type !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txt_orderNumber.Text == "")
            {
                MessageBox.Show("Please Select An Order !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                OrderMaster odr = new OrderMaster();
                odr.orderNumber = Convert.ToInt32(txt_orderNumber.Text);

                odr.updateOrderStatus(odr);
                loadTakeAway();
                clearFields();
                tableArrange();
            }   
        }

       
        private void btn_kotBot_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection(cs);
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("getKot", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@iCat", SqlDbType.VarChar).Value = "K";
            //    cmd.Parameters.Add("@oCode", SqlDbType.VarChar).Value = txt_orderNumber.Text;
            //    cmd.ExecuteNonQuery();

            //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    ad.Fill(ds);

            //    MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            //    // dtg_orders.DataSource = ds.Tables[0];
            //    con.Close();
            //}

            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            if (txt_orderNumber.Text != "")
            {
                frm_invoice frm = new frm_invoice(Convert.ToInt32(txt_orderNumber.Text));
                frm.Show();
                frm.Visible = false;
            }
        }
        private void cmb_itemCode_SelectedValueChanged(object sender, EventArgs e)
        {
            DataBindToTexBox();
        }

        string status;
        private DataTable dt;

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Change kot bot flag
            Orders odr1 = new Orders();
            odr1.orderNumber = Convert.ToInt32(txt_orderNumber.Text);
            odr1.updateKotBotStatus(odr1);

            if (dataValid()) // data valid
            {
                Label lbl1 = new Label();

                // C = completed
                // P = pending
                if (status == "C")
                {
                    lbl1.Text = status;
                }
                else if (status != "C")
                {
                    lbl1.Text = "P";
                }

                Label lbl2 = new Label();

                if (txt_orderType.Text == "Take Away")
                {
                    lbl2.Text = "T";
                }

                else if (txt_orderType.Text == "Dining")
                {
                    lbl2.Text = "D";
                }

                OrderMaster odr = new OrderMaster();

                odr.OrderType = Convert.ToString(lbl2.Text);
                odr.Amount = Convert.ToDecimal(txt_Amount.Text);
                odr.Table = Convert.ToString(txt_table.Text);
                odr.Status = Convert.ToString(lbl1.Text);
                //odr.UserID = Convert.ToInt32(txt_userId.Text);
                odr.UserID = 1000;
                odr.WaiterId = Convert.ToInt32(txt_waiterId.Text);
                odr.SaveMasterRec(odr);
                int order_no = CreateOrderList();

                clearFields();
                tableArrange();
                loadTakeAway();
            }

            else
            {
                MessageBox.Show("First Create An Order !");
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void txt_waiter_TextChanged(object sender, EventArgs e)
        {
            DataBindToTexBox1();
        }

        private void btn_tbl1_DoubleClick(object sender, EventArgs e)
        {
           
            LoadOrderDetails(0, 1);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
         
        }

        private void btn_tbl2_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 2);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl10_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 10);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl3_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 3);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl4_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 4);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl5_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 5);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl6_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 6);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl7_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 7);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl8_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 8);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl9_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 9);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl11_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 11);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl12_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 12);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl13_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 13);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void btn_tbl14_DoubleClick(object sender, EventArgs e)
        {
            LoadOrderDetails(0, 14);

            if (txt_orderNumber.Text != "")
            {
                LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
            }
        }

        private void dtg_TA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (DataGridViewRow row in dtg_TA.SelectedRows)
            {
                txt_orderNumber.Text = row.Cells[0].Value.ToString();
                txt_table.Text = row.Cells[1].Value.ToString();
                txt_userId.Text = row.Cells[2].Value.ToString();
                txt_waiter.Text = row.Cells[3].Value.ToString();
                txt_orderType.Text = "Take Away";

                if (txt_orderNumber.Text != "")
                {
                    LoadOrderDetails1(Convert.ToInt32(txt_orderNumber.Text), 0);
                }
            }
        }

        private void btn_void_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtg_orders.SelectedRows)
            {
                if (row.Selected == true)
                {
                    dtg_orders.Rows.RemoveAt(row.Index);
                }

                else
                {
                    MessageBox.Show("Please Select A Reocrd !", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            FindTotal();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            if (txt_orderNumber.Text != "")
            {
                frm_invoice frm = new frm_invoice(Convert.ToInt32(txt_orderNumber.Text));
                frm.Show();
            }
        }

        private void dtg_orders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}