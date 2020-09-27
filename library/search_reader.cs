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



/*管理员查找读者信息*/


namespace library
{
    public partial class search_reader : Form
    {
        public search_reader()
        {
            InitializeComponent();
        }
        
        //数据库命令

        DataSet ds = new DataSet();
        SqlDataAdapter da;

        private void search_reader_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.reader”中。您可以根据需要移动或删除它。
          //  this.readerTableAdapter.Fill(this.libraryDataSet.reader);

            string sql = "select readerno,readername,sex,tel,readerpass from reader";
            //从数据库查询表中信息

            showinfo(sql);//调用showinfo方法
           



        }
        
        //创建方法，连接数据库，调用信息

        private void showinfo(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "reader");
            dataGridView1.DataSource = ds.Tables["reader"];

        }
        /*查找*/
        private void button2_Click(object sender, EventArgs e)
        {
            
            //定义四个变量以接收文本信息

            string readerno = this.textBox1.Text;
            string readername = this.textBox2.Text;
            string sex = this.textBox3.Text;
            string tel = this.textBox4.Text;
            string sql = "select readerno,readername,sex,tel from reader where 1=1";
            //判断输入信息是否为空

            if (readerno != "")
            {
                sql += string.Format(" and readerno like '%{0}%'", readerno);
            }
            if (readername != "")
            {
                sql += string.Format(" and readername like '%{0}%'", readername);
            }
            if (sex != "")
            {
                sql += string.Format(" and sex like '%{0}%'", sex);
            }
            if (tel != "")
            {
                sql += string.Format(" and tel like '%{0}%'", tel);
            }
            showinfo(sql);


        }
        /*退出*/
        private void button1_Click_1(object sender, EventArgs e)
        {
           // Application.Exit();
            this.Close();
        }
    }

}
