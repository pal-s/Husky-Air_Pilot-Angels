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
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-JER371JI;Initial Catalog=Husky;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            string securepass = FormsAuthentication.HashPasswordForStoringInConfigFile(TextBox4.Text, "MD5");
            Label1.Text = "Your Username is-" + TextBox3.Text;
            Label2.Text = "Your HashPassword is-" + securepass;
            Label2.ForeColor = System.Drawing.Color.ForestGreen;
            Label1.ForeColor = System.Drawing.Color.ForestGreen;

            SqlCommand command = new SqlCommand("insert into login values('" + TextBox3.Text + "','" + securepass + "')", connection);
            command.ExecuteNonQuery();
            Response.Write("Registration is done successfully");
        }
    }
}