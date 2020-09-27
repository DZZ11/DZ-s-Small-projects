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
    public partial class managers : Form
    {
        public managers()
        {
            InitializeComponent();
        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbookcategory my = new addbookcategory();
            my.Show();
          
        }

        private void 修改图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a_alterbook my = new a_alterbook();
            my.ShowDialog();

        }

        private void 查找当前图书库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_remainder my = new book_remainder();
            my.ShowDialog();
        }

        private void 查找借阅信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_borrow my = new search_borrow();
            my.ShowDialog();
        }

        private void 删除读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletereader my = new deletereader();
            my.Show();
        }

        private void 查看读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_reader my = new search_reader();
            my.Show();
        }

        private void 查看图书剩余ToolStripMenuItem_Click(object sender, EventArgs e)
            
            /*删除图书信息*/

        {
            deletebook my = new deletebook();
            my.Show();
        }

        private void 添加读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addreader my = new addreader();
            my.Show();
        }

        private void 图书管理须知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmanageSK my = new bookmanageSK();
            my.Show();
        }
        
        /*管理员添加*/

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_admin my = new add_admin();
            my.Show();
        }

        private void 按读者名删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletereadername my = new deletereadername();
            my.Show();
        }

        private void 按读者电话删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletereadernum my = new deletereadernum();
            my.Show();
        }

        private void 读者管理须知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readerSK my = new readerSK();
            my.Show();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 分类添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbookcategory my = new addbookcategory();
            my.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addreader my = new addreader();
            my.Show();
        }
    }
}
