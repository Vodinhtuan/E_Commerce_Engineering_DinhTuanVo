using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN.App_Code;

namespace NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN
{
    public partial class pageCHITIETSANPHAM : System.Web.UI.Page
    {
        SqlConnection con;
        public DataTable tbSANPHAM; 
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            String path = Server.MapPath("App_Data\\dbQLBH.mdf");
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            con.Open();

            
                String SQL = null;
                if (Request.QueryString.Get("IDSP") != null)
                    SQL = "Select * from tbSANPHAM WHERE IDSANPHAM=" + Request.QueryString.Get("IDSP");
                SqlDataAdapter ADP = new SqlDataAdapter(SQL, con);
                tbSANPHAM = new DataTable();
                ADP.Fill(tbSANPHAM);

                this.Repeater2.DataSource = tbSANPHAM;
                this.Repeater2.DataBind();
            if (!IsPostBack)
            {
                int soluong = Int32.Parse(tbSANPHAM.Rows[0]["SOLUONG"].ToString());
                for (int i = 1; i <= soluong; i++)
                    this.Dropdownlist1.Items.Add(i.ToString());
            } 
            con.Close();
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            int idsanpham = Convert.ToInt32(tbSANPHAM.Rows[0]["IDSANPHAM"]);
            String tensanpham = tbSANPHAM.Rows[0]["TENSANPHAM"].ToString(); 
            int soluong = Convert.ToInt32(Dropdownlist1.Text); 
            Double dongia = Convert.ToDouble(tbSANPHAM.Rows[0]["DONGIA"]);
            Double thanhtien = soluong * dongia;
            String hinhanh = tbSANPHAM.Rows[0]["IDSANPHAM"].ToString();

            ShoppingCart cart;
            if(Session["CART"] != null){
                cart = (ShoppingCart)Session["CART"];
                cart.Additem(idsanpham, tensanpham, dongia, soluong, hinhanh);
            }
            else
            {
                cart = new ShoppingCart();
                cart.Additem(idsanpham, tensanpham, dongia, soluong, hinhanh);
            }

            Session["CART"] = cart;
            Response.Redirect("pageGIOHANG.aspx");
        }
    }
}