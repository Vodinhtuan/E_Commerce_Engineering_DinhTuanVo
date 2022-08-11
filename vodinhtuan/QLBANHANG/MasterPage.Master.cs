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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        LopKetNoi data = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sql = "select * from DanhMuc";
                DataTable dt = data.getData(sql);

                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            else return;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string tenDN = this.Login1.UserName;
            string matkhau = this.Login1.Password;

            string sql = "select * from KhachHang where TENDANGNHAP='" + tenDN +
                        "' and MATKHAU='" + matkhau + "'";

            DataTable dt = data.getData(sql);
            if (dt.Rows.Count > 0)
            {
                Response.Cookies["tendn"].Value = tenDN;
                Response.Redirect("mathang.aspx");

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string madm = ((LinkButton)sender).CommandArgument;
            Response.Redirect("mathang.aspx?madm=" + madm);
        }
    }
}