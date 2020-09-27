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


/*添加管理员*/

namespace library
{
    public partial class add_admin : Form
    {
        public add_admin()
        {
            InitializeComponent();
        }
        //数据库命令
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        //定义查询方法

        /*添加*/

        private void button1_Click(object sender, EventArgs e)
        {
            string adno =this.txtadno.Text;
            string name = this.txtname.Text;
            string pass = this.txtpass.Text;
            string tel = this.txttel.Text;
           
            if (adno == "")
            {
                MessageBox.Show("请输入管理号！");
               
                return;
            }
            if (name == "")
            {
                MessageBox.Show("请输入姓名！");
               
                return;
            }
            if (pass== "")
            {
                MessageBox.Show("请输入密码！");
            
                return;
            }
            if (tel == "")
            {
                MessageBox.Show("请输入联系方式！");
          
                return;
            }
           
            string sql = string.Format("insert into admin values('{0}','{1}','{2}','{3}')", adno, name, pass,tel);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("信息添加成功！");
                   this.txtadno.Text="";
                    this.txtname.Text="";
                     this.txtpass.Text="";
                    this.txttel.Text="";

                }
                else
                {
                    MessageBox.Show("信息添加失败！");
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
            string sql1 = string.Format("select * from admin order by adno desc");
            showinfo(sql1);

        }

        private void showinfo(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "admin");
            dataGridView1.DataSource = ds.Tables["admin"];
        }
        /*取消*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_admin_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select * from admin");
            showinfo(sql);
        }

    }
}
