using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap5
{
    public partial class Bai5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void name_TextChanged(object sender, EventArgs e)
        {
            
            greeting.Text = "Chao ban: " + (sender as TextBox).Text + ". Lop " + grade.Text;
        }

        protected void grade_TextChanged(object sender, EventArgs e)
        {
            greeting.Text = "Chao ban: " + name.Text + ". Lop " + (sender as TextBox).Text;
        }
    }
}