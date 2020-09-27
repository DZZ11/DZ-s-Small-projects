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
    public partial class reader : Form
    {
        public reader()
        {
            InitializeComponent();
        }

        private void 查找图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  find mf = new find();
           // mf.Show();
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowbook mf = new borrowbook();
            mf.Show();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook mf = new returnbook();
            mf.Show();
        }
        
        
        /*读者服务*/

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 我的借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Myborrow fm = new Myborrow();
            fm.Show();
            
            
            /*data.open();
            string aaa= r_login.rn;
            string sql = string.Format("select count('aaa') from borrow ");
            SqlCommand sq=new SqlCommand (sql,data.com);
            SqlDataReader dr = sq.ExecuteReader();
            dr.Read();
            int dn=dr.GetInt32(0);
            string dd=Convert.ToString(dn);
            MessageBox.Show(dd,"借阅数量");*/
        }

        private void 查看个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpersonalview my = new rpersonalview();
            my.ShowDialog();
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           re_changinformation  my = new re_changinformation ();
            my.Show();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 入馆教育ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_education my = new re_education();
            my.Show();
        }

        private void 扫码看书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_codelookbook my = new re_codelookbook();
            my.Show();
        }

        private void 借还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_borrow_news my = new re_borrow_news();
            my.Show();

        }

        private void 最新公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_news my = new re_news();
            my.Show();
        }

        private void 电子书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_electronic_book my = new re_electronic_book();
            my.Show();
        }

        private void 公开课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_open_class my = new re_open_class();
            my.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 查找图书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            find mf = new find();
            mf.Show();
        }

        private void 借阅排行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bwranking fm = new bwranking();
            fm.Show();
        }
    }
}
