using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRole1.Classes.DB;

namespace WebApplication1.Admin
{
    public partial class SubscriptionTypeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string sql = "SELECT SUBSCRIPTIONTYPEID,SUBSCRIPTIONTYPENAME,USERS,STORAGE,BANDWIDTH,TRANSACTIONS1,TRANSACTIONS2,TRANSACTIONS3, DURATION FROM SUBSCRIPTIONTYPE WHERE STATUSFLAG != 'D'";
                DBConnectionMSSQL dc = new DBConnectionMSSQL();
                DataSet dataset = new DataSet();
                dataset = dc.GetDataSet(sql);
                GridView1.DataSource = dataset;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string customerlogo = TextBox1.Text + "-logo.jpg";
            string duration = DropDownList1.SelectedValue;
            //string connectionstring = "User ID=sa;Password=Temp1234";
            string user = "admin";
            string sql = "INSERT INTO [SUBSCRIPTIONTYPE] (SUBSCRIPTIONTYPEID, SUBSCRIPTIONTYPENAME, USERS, STORAGE, BANDWIDTH, DURATION, CREATEDBY, STATUSFLAG)";
            sql += " VALUES('";
            sql += TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + "," + TextBox4.Text + "," + TextBox5.Text + ",'" + duration + "','" + user + "','N')";
            //Response.Write(sql);
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
            Response.Redirect("SubscriptionTypeForm.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubscriptionTypeForm.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string subscriptiontypeid = GridView1.SelectedRow.Cells[1].Text;
            //string sql = "DELETE FROM [CUSTOMERS] WHERE CUSTOMERID = '" + customerid + "'";
            string sql = "UPDATE [SUBSCRIPTIONTYPE] SET STATUSFLAG = 'D' WHERE SUBSCRIPTIONTYPEID = '" + subscriptiontypeid + "'";
            DBConnectionMSSQL dc = new DBConnectionMSSQL();
            try
            {
                int result = dc.GetExecuteQuery(sql);
                Label21.Text = "Customer record is deleted...." + subscriptiontypeid;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            }
        }
    }
}