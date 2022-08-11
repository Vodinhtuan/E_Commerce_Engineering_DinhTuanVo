using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace QLTHIETBI
{
    public class LopKetNoi : System.Web.UI.Page
    {
        SqlConnection cn;
        public LopKetNoi()
        {
            string sqlCon = @"server = DESKTOP-OSDCB7U; Database = DB_THIET_BI; Trusted_connection = true;";
            cn = new SqlConnection(sqlCon);
        }

        public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                //Response.Write(ex.Message);
            }
            return dt;
        }

        public void UpdateData(string sql)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}