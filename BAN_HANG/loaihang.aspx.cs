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
    public partial class loaihang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strCon = "server=DESKTOP-ITK614D;Database=BANHANG;Uid=sa;Pwd=a123456*;Trusted_connection=true;";
            SqlConnection cn = new SqlConnection(strCon);

            string sql = "select * from LOAIHANG";
            SqlDataAdapter sda = new SqlDataAdapter(sql, cn);

            //DataSet ds = new DataSet();
            //sda.Fill(ds);
            //dl_dulieu.DataSource = ds;
            //dl_dulieu.DataBind();

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dl_dulieu.DataSource = dt;
            dl_dulieu.DataBind();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string maloai=((ImageButton)sender).CommandArgument;
            Context.Items["maloai"] = maloai;
            Server.Transfer("Mathang.aspx");

            //Response.Redirect("Mathang.aspx?id="+maloai);

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;
            Context.Items["maloai"] = maloai;
            Server.Transfer("Mathang.aspx");
        }
    }
}