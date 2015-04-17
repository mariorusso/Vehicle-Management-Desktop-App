using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace dataAccess
{
    public class DataAccessClass
    {
        private static SqlConnection conectionObj = new SqlConnection();
       
        public static void myConnection()
        {
            try
            {
                string strConnection = ConfigurationManager.ConnectionStrings["vmsdata"].ToString();
                conectionObj.ConnectionString = strConnection.Trim();
                conectionObj.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public static void fillLocalDataTbl(DataTable tblName, string strSQL)
        {
            try
            {
                lock (conectionObj)
                {
                    if (conectionObj.State == ConnectionState.Closed)
                    {
                        myConnection();
                    }
                    SqlCommand command = new SqlCommand();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    command.Connection = conectionObj;
                    command.CommandText = strSQL;
                    command.CommandType = CommandType.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(tblName);
                    adapter.Dispose();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public static void mySelectQuery(DataSet dset, string stSQL, string tblName)
        {
            try
            {
                lock (conectionObj)
                {
                    if (conectionObj.State == ConnectionState.Closed)
                    {
                        myConnection();
                    }
                    SqlCommand command = new SqlCommand();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    command.Connection = conectionObj;
                    command.CommandText = stSQL;
                    command.CommandType = CommandType.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(dset, tblName);
                    adapter.Dispose();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public static int executeDataSet(DataSet dset, string strSQL, string tblName)
        {
            try
            {
                int num;
                SqlCommand command = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                if (conectionObj.State == ConnectionState.Closed)
                {
                    myConnection();
                }
                command.Connection = conectionObj;
                command.CommandText = strSQL;
                command.CommandType = CommandType.Text;
                adapter.SelectCommand = command;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                builder.ConflictOption = ConflictOption.OverwriteChanges;
                num = adapter.Update(dset, tblName);

                return num;
            }
            catch (Exception ex)
            {

                throw ex;
            }
                        
        }

        public static int executeQuery(string strQuery)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                if (conectionObj.State == ConnectionState.Closed)
                {
                    myConnection();
                }

                command.Connection = conectionObj;
                command.CommandText = strQuery;
                command.CommandType = CommandType.Text;
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
