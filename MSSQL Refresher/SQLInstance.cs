using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Refresher
{
    class SQLInstance
    {
        public SQLInstance()
        { 
            dataController.datasource = getDataSource();
        }
         
        private string getDataSource()
	    {//Test
            string computerName=Environment.MachineName;
            string Instance = "SQLEXPRESS";
               
            SqlDataSourceEnumerator instance =
             SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();

            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    if (col.ColumnName.Contains("ServerName"))
                    {
                        computerName = row[col].ToString();
                    }
                    else
                    if (col.ColumnName.Contains("InstanceName"))
                    {
                        Instance = row[col].ToString();
                    }   
                }
                break;
            }
             
            return computerName + "\\" + Instance;
        }
         
        //this will Display all the Instances of the 
        private static void DisplayData()
        {
            SqlDataSourceEnumerator instance =
          SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
             
            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }
                Console.WriteLine("============================");
            }
        }
    }
}
