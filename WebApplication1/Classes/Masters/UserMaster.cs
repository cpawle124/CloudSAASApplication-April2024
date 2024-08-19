using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole1.Classes.Masters
{
    public class UserMaster
    {
        public UserMaster() { }

        private string usedrid { get; set; }
        private string username { get; set; }
        private string pwd { get; set; }
        private string emailaddress { get; set; }
        private string phone { get; set; }
        private string customerid { get; set; }
        private string isadmin { get; set; }
        private string createdby { get; set; }
        private string createdon { get; set; }
        private string statusflag { get; set; }
    }
}