using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class r_login : Form
    {
        public r_login()
        {
            InitializeComponent();
        }
        public static string rn = null;
        private void button2_Click(object sender, EventArgs e)
        {
               if (r_loginacc.Text == "")
                {
                    MessageBox.Show("登录名不能为空！");
                    r_loginacc.Focus();
                    return;
                }
                if (r_loginpass.Text == "")
                {
                    MessageBox.Show("密码不能为空！");
                    r_loginpass.Focus();
                    return;
                }
                rn = r_loginacc.Text;
                string sql = string.Format("select count(*) from reader where readerno='{0}' and readerpass='{1}'", r_loginacc.Text, r_loginpass.Text);
                try
                {
                    SqlCommand cmd = new SqlCommand(sql,data.com);
                    data.open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count != 0)
                    {
                        MessageBox.Show("登陆成功");
                        reader re = new reader();
                        re.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void r_loginacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r_register my = new r_register();
            my.Show();
        }

    }
}
