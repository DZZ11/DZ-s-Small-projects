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
    public partial class borrowbook : Form
    {
        public borrowbook()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        private void borrowbook_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.book”中。您可以根据需要移动或删除它。
           // this.bookTableAdapter.Fill(this.libraryDataSet.book);
            string sql = "select bookname,number from book";
            zzz(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=library;integrated security=true");
            con.Open();
            string number1 = "select number from book where bookname='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(number1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int num = dr.GetInt32(0);
            con.Close();
            if (num <= 0)
            {
                MessageBox.Show("这本书已经全部借出，请借阅其它书籍！");
                
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=library;integrated security=true");
                conn.Open();
                string number2 = "update book set number=number-1  where bookname='" + textBox1.Text + "'";
                SqlCommand cmb = new SqlCommand(number2, conn);
                cmb.ExecuteNonQuery();
                MessageBox.Show("借阅成功");
                string br = "select bookno from book where bookname='" + textBox1.Text + "'";
                SqlCommand cmb1 = new SqlCommand(br,conn);
                SqlDataReader dr1 = cmb1.ExecuteReader();
                dr1.Read();
                string id = dr1.GetString(0);
                conn.Close();
                SqlConnection conne = new SqlConnection("Data Source=.;Initial Catalog=library;integrated security=true");
                conne.Open();
                string ins = string.Format("insert borrow(b_readerno,b_bookno,borrowtime) values('{0}','{1}','{2}')",r_login.rn,id,DateTime.Now);
                SqlCommand ind = new SqlCommand(ins, conne);
                int count = ind.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("添加借书信息成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
                conne.Close();
            }
            string sql = "select bookname,number from book";
            zzz(sql);
            con.Close();
        }
        private void zzz(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "book");
            dgvborrow.DataSource = ds.Tables["book"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}