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
    public partial class chitiet : System.Web.UI.Page
    {
        LopKetNoi data = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.Cookies["tendn"] != null)
                {
                    if (Request.QueryString["mh"] == null) return;
                    string mahang = Request.QueryString["mh"].ToString();

                    string sql = "select * from HangHoa where MAHANG=" + mahang;
                    DataTable dt = data.getData(sql);

                    this.DataList1.DataSource = dt;
                    this.DataList1.DataBind();
                }
                else
                {
                    Label4.Text = "Bạn phải đăng nhập trước";
                }
            }
            else return;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string mahang = bt.CommandArgument;
            if (Request.Cookies["tendn"] != null)
            {
                string tendn = Request.Cookies["tendn"].Value;
                DataListItem item = (DataListItem)bt.Parent;
                string soluong = ((TextBox)item.FindControl("TextBox1")).Text;

                string sql = "select * from DonHang where TENDANGNHAP='" + tendn + "' and MAHANG=" + mahang;
                DataTable dt = data.getData(sql);
                string sql_update;
                if (dt.Rows.Count > 0)
                {
                    sql_update = "update DonHang set SOLUONG=SOLUONG+" + soluong +
                        " Where TENDANGNHAP='" + tendn + "' and MAHANG=" + mahang;
                }
                else
                {
                    sql_update = "insert into DonHang values('" + tendn + "','" + mahang + "'," + soluong + ")";
                }
                data.UpdateData(sql_update);
                Label4.Text = "NHập dữ liệu thành công";

            }
            else
            {
                Label4.Text = "Bạn phải đăng nhập trước";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("giohang.aspx");

        }
    }
}