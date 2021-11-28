using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace DemoLogin
{
    public partial class LoginForm_demo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Emp_db;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("select * from Signup_demo where Mail=@Mail and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Mail", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if(dt.Rows.Count > 0)
            {
                Response.Redirect("RedirectForm.aspx");
            }
            else
            {
                Label1.Text = "Invalid usernname or password";
                Label1.ForeColor = System.Drawing.Color.Red;

            }



        }
    }
}