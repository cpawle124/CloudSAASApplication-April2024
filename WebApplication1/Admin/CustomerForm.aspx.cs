using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRole1.Classes.DB;

namespace WebApplication1.Admin
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string filePath1 = Server.MapPath("~/App_Data/Themes.xml");
                using (DataSet ds = new DataSet())
                {
                    ds.ReadXml(filePath1);
                    DropDownList1.DataSource = ds;
                    DropDownList1.DataTextField = "Text";
                    DropDownList1.DataValueField = "Value";
                    DropDownList1.DataBind();
                }
                string sql = "SELECT CUSTOMERID,CUSTOMERNAME,CUSTOMERTHEME,ISADMIN FROM CUSTOMERS WHERE STATUSFLAG != 'D'";
                DBConnectionMSSQL dc = new DBConnectionMSSQL();
                DataSet dataset = new DataSet();
                dataset = dc.GetDataSet(sql);
                GridView1.DataSource = dataset;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool IsCorrectEntry = false;
            string customerlogo = TextBox1.Text + "-logo.jpg";
            string customertheme = DropDownList1.SelectedValue;
            string connectionstring = "User ID=sa;Password=Temp1234";
            string user = "admin";
            string sql1 = "INSERT INTO [CUSTOMERS] (CUSTOMERID, CUSTOMERNAME,CUSTOMERLOGO,CUSTOMERTHEME,CONNECTIONSTRING,ISADMIN,CREATEDBY)";
            sql1 += " VALUES('";
            sql1 += TextBox1.Text + "','" + TextBox2.Text + "','" + customerlogo + "','" + customertheme + "','" + connectionstring + "','N','" + user + "')";
            int result = 0;

            //===== Customer Entry
            DBConnectionMSSQL dc = new DBConnectionMSSQL();
            try
            {
                result = dc.GetExecuteQuery(sql1);
                IsCorrectEntry = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message.ToString());
                IsCorrectEntry = false;
            }
            if (result > 0)
            { 
                Label21.Text = "CUSTOMER: Record is validatd & saved..."; 
            }
            else 
            {
                Label21.Text = "CUSTOMER: Record is NOT saved..."; 
            }

            //===== User Entry (Default)
            if (IsCorrectEntry)
            {
                string sql2 = "INSERT INTO [USERMASTER] (USERID, USERNAME, PWD, EMAILADDRESS, PHONE, CUSTOMERID, ISADMIN, CREATEDBY)";
                sql2 += " VALUES('";
                sql2 += "admin', '" + TextBox1.Text + "-admin', 'a', 'admin@" + TextBox1.Text + ".com','123456','" + TextBox1.Text + "','Y','" + user + "')";
                try
                {
                    result = dc.GetExecuteQuery(sql2);
                    IsCorrectEntry = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message.ToString());
                    IsCorrectEntry = false;
                }
                if (result > 0)
                {
                    Label21.Text += "USER: Record is validatd & saved...";
                }
                else
                {
                    Label21.Text += "USER: Record is NOT saved...";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerForm.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerForm.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string customerid = GridView1.SelectedRow.Cells[1].Text;
            //string sql = "DELETE FROM [CUSTOMERS] WHERE CUSTOMERID = '" + customerid + "'";
            string sql = "UPDATE [CUSTOMERS] SET STATUSFLAG = 'D' WHERE CUSTOMERID = '" + customerid + "'";
            DBConnectionMSSQL dc = new DBConnectionMSSQL();
            try
            {
                int result = dc.GetExecuteQuery(sql);
                Label21.Text = "Customer record is deleted...." + customerid;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
        }
    }
}