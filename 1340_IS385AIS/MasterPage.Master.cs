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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        SqlConnection con;
        public DataTable tbDANHMUC;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            String path = Server.MapPath("App_Data\\dbQLBH.mdf");
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +path+ ";Integrated Security=True";

            con.Open();
            String SQL = "Select * from tbDANHMUC";
            SqlDataAdapter ADP = new SqlDataAdapter(SQL, con);
            tbDANHMUC = new DataTable();
            ADP.Fill(tbDANHMUC);

            this.Repeater1.DataSource = tbDANHMUC;
            this.Repeater1.DataBind();
            con.Close();

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}