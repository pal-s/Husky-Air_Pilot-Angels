using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
namespace HUSKY_PILOT_ANGELS
{
    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection("Data Source=LAPTOP-JER371JI;Initial Catalog=Husky;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            connection.Open();

            SqlCommand command = new SqlCommand("Select * from login where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Label1.Text = " Welcome " + TextBox1.Text;
                Response.Write("Login Successfull");
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Invalid username or password");
            }
            connection.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
         }
    }

}