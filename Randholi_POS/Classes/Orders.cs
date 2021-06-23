using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Randholi_POS
{
    class Orders
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        public int ItemCode { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string kotBotStatus { get; set; }
        public int orderNumber { get; set; }

        public int SaveOrderRec(List<Orders> invlist)
        {
            string sql = "SELECT IDENT_CURRENT('tbl_order_master') as odrNO";
            int odrNO = data.ExecuteDataReader(sql);

            foreach (Orders inv in invlist) // send multiples valuse to order file
            {
                inv.Amount = inv.Price * inv.Quantity;
                sql = " INSERT INTO tbl_order_item (order_no, item_code, quantity, price, amount, status) VALUES ('" + odrNO + "', '" + inv.ItemCode + "', '" + inv.Quantity + "', '" + inv.Price + "', '" + inv.Amount + "', '" + inv.kotBotStatus + "') ";
                data.executeSql(sql);
            }

            return odrNO;
        }

        public void updateKotBotStatus(Orders odr)
        {
            string sql = " UPDATE tbl_order_item SET status = 'P' WHERE order_no = '" + odr.orderNumber + "' ";
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
