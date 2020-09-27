using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Myborrow : Form
    {
        public Myborrow()
        {
            InitializeComponent();
        }

        private void 借阅的书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bwbookname fm = new bwbookname();
            fm.Show();
            //string sql = "select b_bookno from borrow where b_readerno='" + r_login.rn + "'";
            //SqlCommand sq = new SqlCommand(sql, DBHelper.conn);
            //SqlDataReader dr = sq.ExecuteReader();
            //if (dr.Read())
            //{
            //    string dn = dr.GetString(0);
            //    string sqd = "select bookname from book where bookno='" + dn + "'";
            //    MessageBox.Show(bookname, "借阅书名");
            //}
            //else
            //{
            //    MessageBox.Show("无未还图书");
            //}
            //DBHelper.closedb();
        }

        private void 未还书名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noreturn fm = new noreturn();
            fm.Show();
            //DBHelper.opendb();
            ////查询语句
            //string sql = "select b_bookno from borrow where b_readerno='" + r_login.rn + "' and returntime is null";
            //SqlCommand sq = new SqlCommand(sql, DBHelper.conn);
            //SqlDataReader dr = sq.ExecuteReader();

            //if (dr.Read())
            //{
            //    string bookno = dr.GetString(0);

            //    MessageBox.Show(bookname, "未还书名");
            //}
            //else
            //{
            //    MessageBox.Show("无未还图书");
            //}
            //DBHelper.closedb();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Myborrow_Load(object sender, EventArgs e)
        {

        }
    }
}
