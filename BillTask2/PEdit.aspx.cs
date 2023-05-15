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
    public partial class PEdit : System.Web.UI.Page
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
                cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.CommandText = "SELECT * FROM Product WHERE id=" + Request.QueryString["id"];
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtname.Text = dr[1].ToString();
                    txtcategory.Text = dr[2].ToString();
                    txtPrice.Text = dr[3].ToString();
                    txtbrand.Text = dr[4].ToString();
                }
                dr.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "Update Product SET name='" + txtname.Text + "',category='" + txtcategory.Text + "',Price='" + txtPrice.Text + "',Brand='"+txtbrand+"' Where id=" + Request.QueryString["id"];
            cmd.ExecuteNonQuery();
            MessageBox.Show("Values Are Updated");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.CommandText = "DELETE FROM Product Where id=" + Request.QueryString["id"];
            cmd.ExecuteNonQuery();
            MessageBox.Show("Values Are Deleted");

        }
    }
}