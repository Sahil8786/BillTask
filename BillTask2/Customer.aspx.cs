using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace BillTask2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection CN;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            CN = new SqlConnection();
            CN.ConnectionString = "Data Source=DESKTOP-KI5E9N1\\SQLEXPRESS;Initial Catalog=aarohi;Integrated Security=True";
            CN.Open();
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "SELECT * FROM Customer";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("~/CEdit.aspx?id=" + GridView1.SelectedRow.Cells[1].Text);
        }
    }
}