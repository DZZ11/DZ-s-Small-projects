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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 按图书号删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebookno fr = new deletebookno();
            fr.Show();
        }

        private void 按图书名删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebookname fr = new deletebookname();
            fr.Show();
        }

        private void 按作者名删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebookauthor fr = new deletebookauthor();
            fr.Show();
        }

        private void 按出版社删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletebookpress fr = new deletebookpress();
            fr.Show();
        }

        private void deletebook_Load(object sender, EventArgs e)
        {

        }
    }
}
