using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN.App_Code;

namespace NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN
{
    public partial class pageGIOHANG : System.Web.UI.Page
    {

        public void LoadCart(ShoppingCart carts)
        {
            this.GridView1.DataSource = carts.CARTS.Values;
            this.GridView1.DataBind();

            this.GridView1.FooterRow.Cells[1].Text = "Tổng thành tiền = ";
            this.GridView1.FooterRow.Cells[4].Text = carts.TotalBill().ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["CART"] != null && !IsPostBack)
            {
                ShoppingCart carts = (ShoppingCart)Session["CART"];
                LoadCart(carts);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ShoppingCart cart = (ShoppingCart)Session["CART"];
            foreach(GridViewRow row in GridView1.Rows)
            {
                CheckBox checkbox=(CheckBox)row.FindControl("CheckBox1");

                int idsanpham = Int32.Parse(row.Cells[0].Text);
                if (checkbox.Checked)
                {
                    cart.Deleteitem(idsanpham);
                }
            }
            Session["CART"] = cart;
            LoadCart(cart);
           
        }
    }
}