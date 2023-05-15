using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BillTask2
{
    public partial class CreateOrder : System.Web.UI.Page
    {
        SqlConnection CN;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            CN = new SqlConnection();
            CN.ConnectionString = "Data Source=DESKTOP-KI5E9N1\\SQLEXPRESS;Initial Catalog=aarohi;Integrated Security=True";
            CN.Open();
            if (!IsPostBack)
            {
                SetDropDownProd();
                SetDropDownCust();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SetDropDownProd()
        {
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "Select * From Product";
            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            dr.Close();

        }
        public void SetDropDownCust()
        {
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "Select * From customer";
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();
            dr.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "insert into Ordermaster Values (" +DropDownList1.SelectedValue + "," + DropDownList2.SelectedValue + ",'" + txtquan.Text + "');";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Values Are Inserted");
        }
    }
}