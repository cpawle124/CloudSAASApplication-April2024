using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRole1.Classes.DB;

namespace WebApplication1.Admin
{
    public partial class UserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string sql = "SELECT USERID,USERNAME,EMAILADDRESS,CUSTOMERID, ISADMIN FROM USERMASTER WHERE STATUSFLAG != 'D'";
                DBConnectionMSSQL dc = new DBConnectionMSSQL();
                DataSet dataset = new DataSet();
                dataset = dc.GetDataSet(sql);
                GridView1.DataSource = dataset;
                GridView1.DataBind();
                TextBox6.Text = Application["CUSTOMERID"] != null ? Application["CUSTOMERID"].ToString() : "WEBLINK";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string customerlogo = TextBox1.Text + "-logo.jpg";
            string user = "admin";
            string sql = "INSERT INTO [USERMASTER] (USERID,USERNAME,PWD,EMAILADDRESS,PHONE, CUSTOMERID, ISADMIN,CREATEDBY)";
            sql += " VALUES('";
            //sql += TextBox1.Text + "','" + TextBox2.Text + "','" + customerlogo + "','" + customertheme + "','" + connectionstring + "','N','" + user + "')";
            sql += TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "','N','" + user + "')";
            int result = 0;
            DBConnectionMSSQL dc = new DBConnectionMSSQL();
            try
            {
                result = dc.GetExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
            if (result > 0)
            { Label21.Text = "Record is validatd & saved..."; }
            else { Label21.Text = "Record is NOT saved..."; }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserForm.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserForm.aspx");
        }
    }
}