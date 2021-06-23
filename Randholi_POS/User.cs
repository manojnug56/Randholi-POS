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

    class User
    {
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();

        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nic { get; set; }
        public string password { get; set; }
        public string userType { get; set; } 
        public string gender { get; set; } 
        public string adress { get; set; } 
        public string contact { get; set; }
        public string registeredDate { get; set; }
        public void selectUser(User usr)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM  tbl_user WHERE id = ' " + usr.userId + "' AND user_password = HashBytes('SHA1', '" + usr.password + "')", cs);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][5].ToString() == "test")
                    {
                        frm_dashboard frm = new frm_dashboard();
                        frm.lbl_role.Text = dt.Rows[0][5].ToString();
                        frm.Show();
                    }

                    else if (dt.Rows[0][5].ToString() == "Admin")
                    {
                        frm_dashboard frm = new frm_dashboard();
                        frm.lbl_role.Text = dt.Rows[0][5].ToString();
                        frm.Show();
                    }

                    else if (dt.Rows[0][5].ToString() == "Manager")
                    {
                        frm_dashboard frm = new frm_dashboard();
                        frm.lbl_role.Text = dt.Rows[0][5].ToString();
                        frm.Show();
                    }

                    else if (dt.Rows[0][5].ToString() == "Cashier")
                    {
                        frm_dashboard frm = new frm_dashboard();
                        frm.lbl_role.Text = dt.Rows[0][5].ToString();
                        frm.btn_utility.Enabled = false;
                        frm.Show();
                    }
                }

                else
                {
                    frm_login frm = new frm_login();
                    frm.Show();
                    MessageBox.Show("Invalid UserName or Password or Both!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void saveUser(User usr)
        {
            using (SqlConnection con = new SqlConnection(cs))
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_user WHERE nic = '" + usr.nic + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int user_exits = (int)cmd.ExecuteScalar();

                    if (user_exits > 0)
                    {
                        MessageBox.Show("User Already Registered !", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        string sql = "INSERT INTO tbl_user (f_name, l_name, nic, user_password, user_type, gender, adress, contact) VALUES ('" + usr.firstName + "','" + usr.lastName + "','" + usr.nic + "', HashBytes('SHA1', '" + usr.password + "'),'" + usr.userType + "','" + usr.gender + "','" + usr.adress + "','" + usr.contact + "') ";
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
        public void updateUser(User usr)
        {
            string sql = "UPDATE tbl_user SET f_name ='" + usr.firstName + "', l_name ='" + usr.lastName + "', nic ='" + usr.nic + "', user_password = HashBytes('SHA1', '" + usr.password + "'), gender ='" + usr.gender + "' , adress ='" + usr.adress + "', contact ='" + usr.contact + "' WHERE id = '" + usr.userId + "' ";
            ExecuteQuery(sql);
            MessageBox.Show("Update Successfull!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void deleteUser(User usr)
        {
            string sql = "DELETE FROM tbl_user WHERE id = '" + usr.userId + "' ";
            ExecuteQuery(sql);
            MessageBox.Show("Successfully Deleted !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void deleteUserSave(User usr)
        {
            string sql = "INSERT INTO tbl_del_user (user_id, f_name, l_name, nic, user_password, user_type, gender, adress, contact, reg_date) VALUES ('" + usr.userId + "','" + usr.firstName + "','" + usr.lastName + "','" + usr.nic + "', HashBytes('SHA1', '" + usr.password + "'),'" + usr.userType + "','" + usr.gender + "','" + usr.adress + "','" + usr.contact + "','" + usr.registeredDate + "') ";
            ExecuteQuery(sql);
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
