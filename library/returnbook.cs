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
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        private void btnre_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text;
            string sql = string.Format("update book set number=number+1  where bookname='{0}'", bookname);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, data.com);
                data.open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("还书成功!");
                    string br = "select bookno from book where bookname='" + textBox1.Text + "'";
                    SqlCommand cmb1 = new SqlCommand(br, data.com);
                    SqlDataReader dr1 = cmb1.ExecuteReader();
                    dr1.Read();
                    string id = dr1.GetString(0);
                    data.close();
                    SqlConnection conne = new SqlConnection("Data Source=.;Initial Catalog=library;integrated security=true");
                    conne.Open();
                    string ins = string.Format("update borrow set returntime='{0}' where b_readerno='"+r_login.rn+"' and b_bookno='{1}'", DateTime.Now,id);
                    SqlCommand ind = new SqlCommand(ins, conne);
                    int count1 = ind.ExecuteNonQuery();
                    if (count1 > 0)
                    {
                        MessageBox.Show("添加还书信息成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                    conne.Close();
                }
                else
                {
                    MessageBox.Show("还书失败!");
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
            textBox1.Text = "";
            string sqd = "select bookname,number from book";
            zzz(sqd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnbook_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.book”中。您可以根据需要移动或删除它。
           // this.bookTableAdapter.Fill(this.libraryDataSet.book);
            string sql = "select bookname,number from book";
            zzz(sql);
        }
        private void zzz(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "book");
            dgvreturn.DataSource = ds.Tables["book"];
        }
    }
}
