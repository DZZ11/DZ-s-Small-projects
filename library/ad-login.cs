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
    public partial class ad_login : Form
    {
        public ad_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adno = this.textBox1.Text;
            string adpass = this.textBox2.Text;

            if (adno == "")
            {
                MessageBox.Show("请输入帐号！");
                textBox1.Focus();
                return;
            }
            if (adpass == "")
            {
                MessageBox.Show("请输入密码！");
                textBox2.Focus();
                return;
            }

            string sql = string.Format("select count(*) from admin where adno='{0}' and adpass='{1}'", adno, adpass);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count != 0)
                {
                    MessageBox.Show("登录成功");
                    managers fm = new managers();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败");

                    return;
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
            //managers myForm = new managers();
           // myForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
