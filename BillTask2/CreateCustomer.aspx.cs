using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BillTask2
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        SqlConnection CN;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            CN = new SqlConnection();
            CN.ConnectionString = "Data Source=DESKTOP-KI5E9N1\\SQLEXPRESS;Initial Catalog=aarohi;Integrated Security=True";
            CN.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "insert into Customer Values ('" + txtname.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "');";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Values Are Inserted");
        }
    }
}