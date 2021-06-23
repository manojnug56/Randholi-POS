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
    class Items
    {
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        public int itemId { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string category { get; set; }
        public string itemType { get; set; }
        public string customeType { get; set; }
        public decimal price { get; set; }
        public string registeredDate { get; set; }
        public int deletedItem { get; set; }

        public void saveItem(Items itm)
        {
            using (SqlConnection con = new SqlConnection(cs))
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_item WHERE f_name = '" + itm.firstName + "' AND type = '" + itm.itemType + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int item_exits = (int)cmd.ExecuteScalar();

                    if (item_exits > 0)
                    {
                        MessageBox.Show("Item Already Registered !", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        string sql = "INSERT INTO tbl_item (f_name, s_name, category, type, cus_type, price) VALUES ('" + itm.firstName + "','" + itm.secondName + "','" + itm.category + "','" + itm.itemType + "','" + itm.customeType + "','" + itm.price + "') ";
                        ExecuteQuery(sql);
                        MessageBox.Show("Registration Successfull!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                }
        }
        public void updateItem(Items itm)
        {
            string sql = "UPDATE tbl_item SET f_name ='" + itm.firstName + "', s_name ='" + itm.secondName + "', category ='" + itm.category + "', type ='" + itm.itemType + "' , cus_type ='" + itm.customeType + "', price ='" + itm.price + "' WHERE id = '" + itm.itemId + "' ";
            ExecuteQuery(sql);
            MessageBox.Show("Update Successfull!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void deleteItem(Items itm)
        {
            string sql = "DELETE FROM tbl_item WHERE id = '" + itm.itemId + "' ";
            ExecuteQuery(sql);
            MessageBox.Show("Successfully Deleted !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public DataSet getData(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }
}
