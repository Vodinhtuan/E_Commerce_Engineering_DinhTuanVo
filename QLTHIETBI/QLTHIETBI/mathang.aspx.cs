using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace QLTHIETBI
{
    public partial class mathang : System.Web.UI.Page
    {
        LopKetNoi data = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string sql;
            if (Request.QueryString["mn"] == null)
            {
                sql = "select * from THIETBI";
            }
            else
            {
                string manhom = Request.QueryString["mn"].ToString();
                sql = "select * from THIETBI where MANHOM=" + manhom;
            }

            DataTable dt = data.getData(sql);
            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();
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