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

/*按读者电话删除*/

namespace library
{
    public partial class deletereadernum : Form
    {
        public deletereadernum()
        {
            InitializeComponent();
        }
        
        /*删除*/

        private void button1_Click(object sender, EventArgs e)
        {

            string readernum = this.textBox1.Text;
            if (readernum == "")
            {
                MessageBox.Show("请输入要删除的读者号！");
                textBox1.Focus();
                return;
            }
            string sql = string.Format("delete from reader where tel = '{0}'", readernum);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("读者信息删除成功！");
                }
                else
                {
                    MessageBox.Show("读者信息删除失败！");
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
        
        /*取消*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
