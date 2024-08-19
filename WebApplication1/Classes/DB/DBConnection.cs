using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole1.Classes.DB
{
    public class DBConnection
    {
        string DBServer = "";
        public DBConnection()
        {
            DBServer = "MSSQL";
        }
        public DBConnection(string str)
        {
            DBServer = str;
        }


        //public DataReader GetDataReader(string query, string ttype)
        //{
        //}

    }
}