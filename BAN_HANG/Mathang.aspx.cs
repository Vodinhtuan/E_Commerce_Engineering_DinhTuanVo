using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAN_HANG
{
    public partial class Mathang : System.Web.UI.Page
    {
        public object GridView1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string strCon = "server=DESKTOP-ITK614D;Database=BANHANG;Uid=sa;Pwd=a123456*;Trusted_connection=true;";
            SqlConnection cn = new SqlConnection(strCon);
            if (Context.Items["maloai"]==null)
            {
                Response.Redirect("loaihang.aspx");
            }   

            string maloai = Context.Items["maloai"].ToString();
            string sql = "select * from MATHANG where MALOAI ="  + maloai;
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);
/*
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();*/


        }
    }
}