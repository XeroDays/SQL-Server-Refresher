using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSSQL_Refresher
{
    public delegate void completedCallback(DataTable data_Tbl,bool isAvailible);

    public class ThreadController
    {

        completedCallback _callback;
       
        public ThreadController(completedCallback callback)
        {
            this._callback = callback;
        }

        static void printDatatable(DataTable tbl)
        {
            foreach (DataRow row in tbl.Rows)
            {
                Console.WriteLine(row[0]);
            }
        }

        public void getDatabaseNames(string dataSource)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("dbName");
            try
            {
                string connectionString = "Data Source="+ dataSource + "\\SQLEXPRESS; Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                tbl.Rows.Add(dr[0].ToString());
                            }
                            
                        }
                    }

                }

                _callback(tbl, true);
            }
            catch (Exception)
            {
                _callback(tbl, false);
             
            }
                

           
        }


    }
}
