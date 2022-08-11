using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
  
namespace QLBANHANG
{
    public partial class mathang : System.Web.UI.Page
    {
        LopKetNoi data = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sql;
                if (Request.QueryString["madm"] == null)
                {
                    sql = "select * from HangHoa";
                }
                else
                {
                    string madm = Request.QueryString["madm"].ToString();
                    sql = "select * from HangHoa where MADM=" + madm;
                }

                DataTable dt = data.getData(sql);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            else return;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            string mahang = ((ImageButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Response.Redirect("chitiet.aspx?mh=" + mahang);
        }
    }
}