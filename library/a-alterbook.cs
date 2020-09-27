using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library
{
    public partial class a_alterbook : Form
    {
        public a_alterbook()
        {
            InitializeComponent();
        }
        //数据库命令
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder mycmdbuilder = new SqlCommandBuilder(da);
            //如果有数据改动
            if (ds.HasChanges())
            {
                try
                {
                    da.Update(ds, "book");
                    MessageBox.Show("图书信息修改成功！");//修改数据

                }
                catch (Exception)
                {
                    MessageBox.Show("图书信息修改失败！");//更新数据
                }
                finally
                {
                    data.close();
                }
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void a_alterbook_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet6.reader”中。您可以根据需要移动或删除它。
            //this.readerTableAdapter.Fill(this.libraryDataSet6.reader);
            string strconn = "server=.;database=library;integrated security= true";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string mysql = "select * from book ";
            //where readerno='" + r_login.rn + "'
            SqlCommand comm = new SqlCommand(mysql, conn);

            da = new SqlDataAdapter(mysql, data.com);
            da.Fill(ds, "book");
            dataGridView1.DataSource = ds.Tables["book"];
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体",12);//设置字体
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;//字体颜色
            dataGridView1.GridColor = Color.Blue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;//
        }
    }
}
