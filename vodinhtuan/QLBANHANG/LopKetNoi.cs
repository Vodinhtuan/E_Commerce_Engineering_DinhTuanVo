using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace QLBANHANG
{
    public class LopKetNoi : System.Web.UI.Page
    {
        SqlConnection cn;
        public LopKetNoi()
        {
            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='"+ Server.MapPath("App_Data/QLBANHANG.mdf")  + "';Integrated Security=True";
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

            }
            finally
            {
                cn.Close();
            }
        }
    }
}