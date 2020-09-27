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
    public partial class addreader : Form
    {
        public addreader()
        {
            InitializeComponent();
        }
        
        private void addreader_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet2.reader”中。您可以根据需要移动或删除它。
           // this.readerTableAdapter.Fill(this.libraryDataSet2.reader);
            // TODO: 这行代码将数据加载到表“libraryDataSet1.reader”中。您可以根据需要移动或删除它。
         //   this.readerTableAdapter.Fill(this.libraryDataSet1.reader);
            // TODO: 这行代码将数据加载到表“libraryDataSet2.reader”中。您可以根据需要移动或删除它。
         //   this.readerTableAdapter.Fill(this.libraryDataSet2.reader);
            string sql = "select* from reader";
            showinfo(sql);

            
        }
//数据库命令
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        //定义查询方法
        private void showinfo(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "reader");
            dataGridView1.DataSource = ds.Tables["reader"];
        }


        private void button1_Click(object sender, EventArgs e)
        {
      /*  //数据库命令
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        //定义查询方法
        private void showinfo(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "reader");
            alterdataGridView1.DataSource = ds.Tables["reader"];
        }*/
            string readerno = this.txtreaderno.Text;
            string readername = this.txtreadername.Text;
            string sex = this.txtsex.Text;
            string tel = this.txttel.Text;
            string readerpass = this.txtreaderpass.Text;
            if (readerno == "")
            {
                MessageBox.Show("请输入要添加的读者号！");
                txtreaderno.Focus();
                return;
            }
            if (readername == "")
            {
                MessageBox.Show("请输入要添加的读者名！");
                txtreadername.Focus();
                return;
            }
            if (sex == "")
            {
                MessageBox.Show("请输入要添加的性别！");
                txtsex.Focus();
                return;
            }
            if (tel == "")
            {
                MessageBox.Show("请输入要添加的联系方式！");
                txttel.Focus();
                return;
            }
            if (readerpass == "")
            {
                MessageBox.Show("请输入要添加的读者密码！");
                txttel.Focus();
                return;
            }
            string sql = string.Format("insert into reader values('{0}','{1}','{2}','{3}','{4}')", readerno, readername, sex, tel,readerpass);
           // MessageBox.Show(sql);
             try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("读者信息添加成功！");
                  this.txtreaderno.Text="";
                 this.txtreadername.Text="";
                  this.txtsex.Text="";
                   this.txttel.Text="";
                  this.txtreaderpass.Text="";

                }
                else
                {
                    MessageBox.Show("读者信息添加失败！");
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
             string sql1 = string.Format("select* from reader order by readerno desc");
             showinfo(sql1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtreaderno.Text = "";
            this.txtreadername.Text = "";
            this.txtsex.Text = "";
            this.txttel.Text = "";
            this.txtreaderpass.Text = "";
            this.Close();
        }
    }
}
