using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLTHIETBI
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        LopKetNoi data = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;

            string sql = "select * from NHOMTHIETBI";
            DataTable dt = data.getData(sql);

            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string manhom = ((LinkButton)sender).CommandArgument;
            Response.Redirect("mathang.aspx?mn=" + manhom);
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string tenDN = this.Login1.UserName;
            string matkhau = this.Login1.Password;

            string sql = "select * from KHACHHANG where TENDANGNHAP='" + tenDN + 
                        "' and MATKHAU='" + matkhau + "'";

            DataTable dt = data.getData(sql);
            if (dt.Rows.Count > 0)
            {
                Response.Cookies["tendn"].Value = tenDN;
                //Response.Redirect("mathang.aspx");
                Server.Transfer("mathang.aspx");
            }
        }
    }
}