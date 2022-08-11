using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap5
{
    public partial class Bai6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            result.Text = $"Ket qua tinh cong la: {Convert.ToDouble((FirstNumber.Text)) + Convert.ToDouble(SecondNumber.Text)}";
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            result.Text = $"Ket qua tinh tru la: {Convert.ToDouble(FirstNumber.Text) - Convert.ToDouble(SecondNumber.Text)}";
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            result.Text = $"Ket qua tinh nhan la: {Convert.ToDouble(FirstNumber.Text) * Convert.ToDouble(SecondNumber.Text)}";
        }

        protected void div_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(SecondNumber.Text) != 0)
            {
                result.Text = $"Ket qua tinh chia la: {Convert.ToDouble(FirstNumber.Text) / Convert.ToDouble(SecondNumber.Text)}";
            }
            else
            {
                result.Text = "Khong hop le!";
            }
        }
    }
}