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
    public partial class deletebookname : Form
    {
        public deletebookname()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = this.textBox1.Text;
            if (bookname == "")
            {
                MessageBox.Show("请输入要删除图书的图书名！");
                textBox1.Focus();
                return;
            }
            string sql = string.Format("delete from book where bookname = '{0}'", bookname);
            MessageBox.Show(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("图书信息删除成功！");
                }
                else
                {
                    MessageBox.Show("图书信息删除失败！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               data.close();
            }
        }

        private void deletebookname_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
