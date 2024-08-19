using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebRole1.Classes.DB
{
    public class DBConnectionMSSQL
    {
        string ConnString = "";
        public DBConnectionMSSQL(string str)
        {
            //ConnString = "Data Source=.\\SQLEXPRESS2008;Initial Catalog=SaaS;" + str;
            ConnString = ConfigurationManager.ConnectionStrings["ConnectionStringMSSQL1"].ConnectionString + str;
        }

        public DBConnectionMSSQL()
        {
            ConnString = ConfigurationManager.ConnectionStrings["ConnectionStringMSSQL"].ConnectionString;
        }
        
        // ----- Getting connection
        public SqlConnection GetDataConnection()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                conn.Open();
            }
            catch
            { }
            return (conn);
        }

        // ----- Getting Reader
        public SqlDataReader GetDataReader(string query, string ttype)
        {
            SqlConnection connection = this.GetDataConnection();
            SqlCommand command = new SqlCommand(query, connection);
            if (ttype.Equals("SP"))
            {
                command.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                command.CommandType = CommandType.Text;
            }
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection); //Is CommandBehavior working here...
            //connection.Close();

            return (reader);
        }

        // ----- Getting Dataset
        public DataSet GetDataSet(string query)
        {
            DataSet ds = new DataSet();
            SqlConnection connection = this.GetDataConnection();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);
                connection.Close();
            }
            catch (Exception e) { }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }

            return (ds);
        }

        // ----- Executing Query
        public int GetExecuteQuery(string query)
        {
            SqlConnection connection = this.GetDataConnection();
            SqlCommand command = new SqlCommand(query, connection);
            int result = 0;
            try
            {
                command.ExecuteNonQuery();
                result = 1;
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return (result);
        }

        //----- Creating DB SP execution
        public int ExecuteDBCreate(string db)
        {
            SqlConnection connection = this.GetDataConnection();
            SqlCommand command = new SqlCommand("CreateApplicationData", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DB_Name", SqlDbType.VarChar).Value = db;

            int result = 0;
            try
            {
                command.ExecuteNonQuery();
                result = 1;
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return (result);
        }
    }
}