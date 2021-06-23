using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Randholi_POS
{
    class data
    {
        static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        public static void executeSql(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static int ExecuteDataReader(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int odrNO = Convert.ToInt32(dr["odrNO"]);

                return odrNO;
            }
        }
    }
}
