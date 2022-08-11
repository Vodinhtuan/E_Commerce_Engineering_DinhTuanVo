using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace NGUYENQUOCTUAN_1340_IS385AIS_DOANCANHAN
{
    public partial class pageDANHSACHSANPHAM : System.Web.UI.Page
    {
        SqlConnection con;
        public DataTable tbSANPHAM;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            String path = Server.MapPath("App_Data\\dbQLBH.mdf");
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +path+ ";Integrated Security=True";
            con.Open();
            String SQL = "Select * from tbSANPHAM";
            if (Request.QueryString.Get("IDDM") != null)
                SQL += " Where IDDANHMUC=" + Request.QueryString.Get("IDDM");
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, con);
            tbSANPHAM = new DataTable();
            ADP.Fill(tbSANPHAM);

            this.DataList1.DataSource = tbSANPHAM;
            this.DataList1.DataBind();
            this.DataList1.RepeatColumns = 5;
            con.Close();
        }
    }
}