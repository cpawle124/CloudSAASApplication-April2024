using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Application : System.Web.UI.MasterPage
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //------ Temp code
                string customerid = Application["CUSTOMERID"] != null ? Application["CUSTOMERID"].ToString().Trim() : "Temp";
                string userid = Application["USERID"] != null ? Application["USERID"].ToString().Trim() : "Temp";
                string admin = Application["ISADMIN"] != null ? Application["ISADMIN"].ToString().Trim() : "N";
                //Response.Write(customerid + userid + admin);

                ////----- Original code - 1
                //if (Application["CUSTOMERID"].ToString() == "WEBLINK")
                //{
                //    XmlDataSource1.DataFile = "~/App_Data/MenuList1.xml";
                //}
                //else
                //{
                //    if (admin == "Y")
                //    { XmlDataSource1.DataFile = "~/App_Data/MenuList2.xml"; }
                //    else
                //    { XmlDataSource1.DataFile = "~/App_Data/MenuList3.xml"; }
                //}
                //Label20.Text = userid + "/" + customerid;
                //Label20.Text += (admin == "Y") ? " (ADMIN)" : " (TENANT)";
                //Label20.Text += (Application["CUSTOMERID"].ToString() == "WEBLINK") ? " (ADMIN)" : " (TENANT)";

                //-----Original code - 2
                if (customerid == "WEBLINK")
                {
                    XmlDataSource1.DataFile = "~/App_Data/MenuList1.xml";
                    Label20.Text = userid + "/" + customerid + " (S ADMIN)";
                }
                else
                {
                    if (admin == "Y")
                    { 
                        XmlDataSource1.DataFile = "~/App_Data/MenuList2.xml";
                        Label20.Text = userid + "/" + customerid + " (ADMIN)";
                    }
                    else
                    { 
                        XmlDataSource1.DataFile = "~/App_Data/MenuList3.xml";
                        Label20.Text = userid + "/" + customerid + " (TENANT)";
                    }
                }
            }
        }
    }
}