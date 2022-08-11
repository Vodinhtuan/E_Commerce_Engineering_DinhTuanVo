using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap5
{
    public partial class Bai7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resolve_Click(object sender, EventArgs e)
        {
            float AValue = float.Parse(a.Text);
            float BValue = float.Parse(b.Text);
            float CValue = float.Parse(c.Text);
            float delta = BValue * BValue - 4 * AValue * CValue;
            if (AValue == 0 && BValue == 0 && CValue != 0)
            {
                result.Text = $"Phuong trinh vo nghiem";
            }

            if (AValue == 0 && BValue == 0 && CValue == 0)
            {
                result.Text = $"Phuong trinh co nghiem la R";
            }

            if (AValue == 0 && BValue != 0)
            {
                result.Text = $"Phuong trinh co nghiem duy nhat la {(-CValue / BValue)}";
            }

            if (delta < 0)
            {
                result.Text = $"Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                result.Text = $"Phuong trinh co nghiem duy nhat la {-BValue / 2 * AValue}";
            }
            else
            {
                result.Text = $"Phuong trinh co 2 nghiem la {(-BValue + (Math.Sqrt(delta))) / 2 * AValue} va {(-BValue - (Math.Sqrt(delta))) / 2 * AValue}";
            }
        }
    }
}