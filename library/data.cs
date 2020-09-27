using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library
{
    class data
    {
        private static string conn = "Data Source=.;Initial Catalog=library;Integrated Security=True";
        public static SqlConnection com = new SqlConnection(conn);
       
        //打开数据库

        public static void open()
        {
            if (data.com.State == System.Data.ConnectionState.Closed)
            {
                data.com.Open();
            }
        }
        
        //关闭数据库

        public static void close()
        {
            if (data.com.State == System.Data.ConnectionState.Open)
            {
                data.com.Close();
            }
        }

    }
}
