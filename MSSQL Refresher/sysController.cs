using DatabaseFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Refresher
{
    class sysController
    {
        public static void truncateTable(string tablename)
        {
            string sql = "Delete From " + tablename;
            new dbServer(dataController.conLink).getQueryScaller(sql);
        }

        public static void table_Reseed_Identity(string tablename)
        {
            if (checkifTable_has_identityColumn(tablename))
            {
                string sql = "DBCC CHECKIDENT ('" + tablename + "', RESEED, 0)";
                new dbServer(dataController.conLink).getQueryScaller(sql);
            }
            
        }

        private static bool checkifTable_has_identityColumn(string tablename)
        {
            string sql = "SELECT Count(column_id) FROM sys.identity_columns WHERE OBJECT_NAME(object_id) = '" + tablename + "'";
            if (sqlAssistant.getIntOnQuery(sql)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 


    }

     class sqlAssistant
    {

        public static int getIntOnQuery(string sql)
        {
            int value =  Convert.ToInt32(new dbServer(dataController.conLink).getQueryScaller(sql));
            return value;
        }
    }
}
