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

/*查找当前图书库存*/


namespace library
{
    public partial class book_remainder : Form
    {
        public book_remainder()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        
        /*创建方法*/

        private void showinfo(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "book");
            dataGridView1.DataSource = ds.Tables["book"];

        }


          /*从数据库中查找信息*/

          private void book_remainder_Load(object sender, EventArgs e)
        {
            string sql = "select bookno,bookname,press,author,number from book ";
            showinfo(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        /*退出*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        /*查找*/

        private void button2_Click(object sender, EventArgs e)
        {

            
            /*定义四个变量*/


            string bookname = this.textBox1.Text;
            string bookno = this.textBox2.Text;
            string press = this.textBox3.Text;
            string author = this.textBox4.Text;
            string sql = "select * from book where 1=1";

            //判断输入信息是否为空
            
            if (bookname != "")
            {
                sql += string.Format(" and bookname like '%{0}%'", bookname);
            }
            if (bookno != "")
            {
                sql += string.Format(" and bookno like '%{0}%'", bookno);
            }
            if (press != "")
            {
                sql += string.Format(" and press like '%{0}%'", press);
            }
            if (author != "")
            {
                sql += string.Format(" and author like '%{0}%'", author);
            }
            showinfo(sql);


        }

       

    }
}
