using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Randholi_POS
{
    class OrderMaster
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        public String OrderType { get; set; }
        public Decimal Amount { get; set; }
        public String Table { get; set; }
        public String Status { get; set; }
        public int UserID { get; set; }
        public int WaiterId { get; set; }
        public int orderNumber { get; set; }

        public void SaveMasterRec(OrderMaster odr)
        {
            string sql = "INSERT INTO tbl_order_master (order_type, amount, table_no, status, user_id, waiter_id) VALUES ('" + odr.OrderType + "','" + odr.Amount + "','" + odr.Table + "','" + odr.Status + "','" + odr.UserID + "','" + odr.WaiterId + "') ";
            data.executeSql(sql);
        }

        public void updateOrderStatus(OrderMaster odr)
        {
            string sql = " UPDATE tbl_order_master SET status = 'C' WHERE order_no = '" +odr.orderNumber+ "' ";
            ExecuteQuery(sql);
            MessageBox.Show("Update Successfull!", "Payment Successfull !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ExecuteQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                }
                return;
            }
        }
    }
}
