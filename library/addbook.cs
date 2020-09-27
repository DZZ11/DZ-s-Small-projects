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
    public partial class 添加图书信息 : Form
    {
        public 添加图书信息()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtbookno.Text = "";
            this.txtbookname.Text = "";
            this.txtauthor.Text = "";
            this.txtpress.Text = "";
            this.txtnumber.Text = "";
            this.Close();
        }

        private void addbook_Load(object sender, EventArgs e)
        {
            string sql = "select * from book";
            zx(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookno = this.txtbookno.Text;
            string bookname = this.txtbookname.Text;
            string author = this.txtauthor.Text;
            string press = this.txtpress.Text;
            int number = Convert.ToInt32(this.txtnumber.Text);
            string bookcategory = this.txtbookcategory.Text;
            if (bookno == "")
            {
                MessageBox.Show("请输入图书号！");
                txtbookno.Focus();
                return;
            }
            if (bookname == "")
            {
                MessageBox.Show("请输入图书名！");
                txtbookname.Focus();
                return;
            }
            if (author == "")
            {
                MessageBox.Show("请输入作者！");
                txtauthor.Focus();
                return;
            }
            if (press == "")
            {
                MessageBox.Show("请输入出版社！");
                txtpress.Focus();
                return;
            }
            if (number == 0)
            {
                MessageBox.Show("请输入图书库存！");
                txtnumber.Focus();
                return;
            }
            if (bookcategory == "")
            {
                MessageBox.Show("请输入图书分类！");
                txtbookcategory.Focus();
                return;
            }
            string sql = string.Format("insert into book(bookno,bookname,author,press,number,bookcategory) values('{0}','{1}','{2}','{3}',{4},'{5}')", bookno, bookname, author, press, number, bookcategory);
            //string sql1 = string.Format("select * from book order by'{0}'desc",bookno );

            try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("图书信息添加成功！");
                    this.txtbookno.Text="";
                     this.txtbookname.Text="";
                     this.txtauthor.Text="";
                     this.txtpress.Text="";
                    this.txtnumber.Text="";
                    this.txtbookcategory.Text="";
                }
                else
                {
                    MessageBox.Show("图书信息添加失败！");
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
            //string sqd = "select * from book";
            string sql1 = string.Format("select* from book order by bookno desc");
            zx(sql1);
        }
        private void zx(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "book");
            dataGridView1.DataSource = ds.Tables["book"];
        }

    }
}



