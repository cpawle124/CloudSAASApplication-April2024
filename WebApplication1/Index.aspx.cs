using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRole1.Classes.DB;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TextBox1.Text = "WEBLINK";
                TextBox2.Text = "admin";
                TextBox3.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringMSSQL"].ConnectionString);
            string customerid = TextBox1.Text;
            string userid = TextBox2.Text;
            string password = TextBox3.Text;
            string query1 = "SELECT * FROM [USERMASTER] WHERE USERID = '" + userid + "' and PWD = '" + password + "' AND CUSTOMERID = '" + customerid + "'";
            int result = 0;
            DBConnectionMSSQL dbc1 = new DBConnectionMSSQL();

            Application["USERID"] = "";
            Application["CUSTOMERID"] = "";
            Application["ISADMIN"] = "";

            SqlDataReader reader1 = dbc1.GetDataReader(query1, "");
            while (reader1.Read())
            {
                Application["USERID"] = reader1["USERID"];
                Application["CUSTOMERID"] = reader1["CUSTOMERID"];
                Application["ISADMIN"] = reader1["IsAdmin"];
                result = 1;
            }
            if (result > 0)
            {
                Response.Redirect("~\\Application.aspx");
                //Response.Write(Application["CUSTOMERID"].ToString() + Application["USERID"].ToString() + Application["ISADMIN"].ToString());
            }
            else
            {
                Label5.Text += "Authentication failed..." + TextBox2.Text;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "INFOGAIN";
            TextBox2.Text = "admin";
            TextBox3.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "INFOGAIN";
            TextBox2.Text = "abcde";
            TextBox3.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "WEBLINK";
            TextBox2.Text = "admin";
            TextBox3.Focus();
        }
    }
}