using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    class DBHelper
    {
        public static string strcon = "Data Source=.;Initial Catalog=library;integrated security=true;";
        public static SqlConnection conn = new SqlConnection(strcon);

        //打开数据库连接
        public static void opendb()
        {
            if (DBHelper.conn.State == System.Data.ConnectionState.Closed)
            {
                DBHelper.conn.Open();
            } 
        }

        //关闭数据库连接
        public static void closedb()
        {
            if (DBHelper.conn.State == System.Data.ConnectionState.Open)
            {
                DBHelper.conn.Close();
            }
        }
    }
}
