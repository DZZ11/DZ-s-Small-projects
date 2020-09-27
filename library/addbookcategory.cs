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
    public partial class addbookcategory : Form
    {
        public addbookcategory()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        private void addbookcategory_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet11.book”中。您可以根据需要移动或删除它。
           // this.bookTableAdapter.Fill(this.libraryDataSet11.book);
            string sql = string.Format("select bookno,bookname,author,press,number,bookcategory from book");
            zx(sql);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookno = this.txtbookno.Text;
            string bookname = this.txtbookname.Text;
            string author = this.txtauthor.Text;
            string press = this.txtpress.Text;
            int number = Convert.ToInt32(this.txtnumber.Text);
            string bookcategory = this.txtbookcateporg.Text;
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
                MessageBox.Show("请输入作者名！");
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
                txtbookcateporg.Focus();
                return;
            }
            string sql = string.Format("insert into book(bookno,bookname,author,press,number,bookcategory) values('{0}','{1}','{2}','{3}',{4},'{5}')", bookno,bookname,author,press,number,bookcategory);
            //  MessageBox.Show(sql);
            try
            {
                //SqlCommand cmd = new SqlCommand(sql, DBHelper.cnn);
                //DBHelper.opendb();
                SqlCommand cmd = new SqlCommand(sql, data.com);
                //DBHelper.opendb();
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
                  this.txtbookcateporg.Text = "";
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

            string sql1 = string.Format("select bookno,bookname,author,press,number,bookcategory from book order by bookno desc");
            zx(sql1);

        }
                    private void zx(string sql)
        {
            ds.Clear();
            da=new SqlDataAdapter(sql,data.com);
            da.Fill(ds,"book");
            dataGridView1.DataSource=ds.Tables["book"];
        }

                    private void textBox1_TextChanged(object sender, EventArgs e)
                    {

                    }

                    private void button2_Click(object sender, EventArgs e)
                    {

                    }

                    private void txtbookname_TextChanged(object sender, EventArgs e)
                    {

                    }

                    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
                    {

                    }

                    private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
                    {

                    }

                    private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
                    {

                    }

                    private void label2_Click(object sender, EventArgs e)
                    {

                    }

                    private void label1_Click(object sender, EventArgs e)
                    {

                    }

                    private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
                    {

                    }

                    private void label3_Click(object sender, EventArgs e)
                    {

                    }

                    private void textBox2_TextChanged(object sender, EventArgs e)
                    {

                    }
    }
}
