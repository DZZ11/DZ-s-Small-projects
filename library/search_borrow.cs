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
    public partial class search_borrow : Form
    {
        public search_borrow()
        {
            InitializeComponent();
        }

      //数据库命令

            DataSet ds = new DataSet();
            SqlDataAdapter da;


        private void search_borrow_Load(object sender, EventArgs e)
        {
            string sql = "select borrow.b_readerno,reader.readername,b_bookno ,book.bookname ,borrowtime,returntime from reader,book,borrow where reader.readerno=borrow.b_readerno and book.bookno=borrow.b_bookno ";
            //从数据库查询表中信息

            showinfo(sql);//调用showinfo方法
        }

        //创建方法，连接数据库，调用信息

        private void showinfo(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "reader,book,borrow");
            dataGridView2.DataSource = ds.Tables["reader,book,borrow"];

        }

        
        /*查找*/

        private void button1_Click(object sender, EventArgs e)
        {
            //定义四个变量以接收文本信息

            string bookname = this.textBox1.Text;
            string bookno = this.textBox2.Text;
            string readerno = this.textBox3.Text;
            string readername = this.textBox4.Text;
            string sql = "select borrow.b_readerno,reader.readername,b_bookno ,book.bookname ,borrowtime,returntime from reader,book,borrow where reader.readerno=borrow.b_readerno and book.bookno=borrow.b_bookno ";
            
            //判断输入信息是否为空

            if (bookname!= "")
            {
            
                sql += string.Format(" and book.bookname like '%{0}%'", bookname);
            }
            if (bookno != "")
            {
                sql += string.Format(" and book.bookno like '%{0}%'", bookno);
            }
            if (readerno != "")
            {
                sql += string.Format(" and reader.readerno like '%{0}%'",readerno);
            }
            if (readername != "")
            {
                sql += string.Format(" and reader.readername like '%{0}%'", readername);
            }
            showinfo(sql);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






    }
}
