using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library
{
    public partial class noreturn : Form
    {
        public noreturn()
        {
            InitializeComponent();
        }

        private void noreturn_Load(object sender, EventArgs e)
        {
            data.open();
            //查询语句
            string sql = "select bookname from book where bookno in (select b_bookno from borrow where b_readerno='201801' and returntime is null)";
            SqlCommand sq = new SqlCommand(sql, data.com);
            SqlDataReader dr = sq.ExecuteReader();
            string temp = "";
            while (dr.Read())
            {
                temp += dr.GetString(0) + "/";

            }
            textBox1.Text = temp;
        }
    }
}
