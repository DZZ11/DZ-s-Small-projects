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
    public partial class deletebookpress : Form
    {
        public deletebookpress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string press = this.textBox1.Text;
            if (press == "")
            {
                MessageBox.Show("请输入要删除图书的图书出版社！");
                textBox1.Focus();
                return;
            }
            string sql = string.Format("delete from book where press = '{0}'", press);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
