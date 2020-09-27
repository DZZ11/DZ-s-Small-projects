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
    public partial class re_changinformation : Form
    {
        public re_changinformation()
        {
            InitializeComponent();
        }
          //数据库命令
           DataSet ds = new DataSet();
           SqlDataAdapter da;
        private void re_changinformation_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet6.reader”中。您可以根据需要移动或删除它。
            //this.readerTableAdapter.Fill(this.libraryDataSet6.reader);
            string strconn="server=.;database=library;integrated security= true";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
             string mysql="select * from reader where readerno='"+r_login .rn +"'";
           SqlCommand comm = new SqlCommand(mysql,conn);
           
           da = new SqlDataAdapter(mysql, data.com);
           da.Fill(ds, "reader");
           changeinfrdataGridView1.DataSource =ds.Tables ["reader"];
           changeinfrdataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("宋体",12);//设置字体
           changeinfrdataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black ;//字体颜色
           changeinfrdataGridView1.GridColor = Color.Blue;
           changeinfrdataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;//
           
        }

        private void changebutton1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder mycmdbuilder = new SqlCommandBuilder(da);
            //如果有数据改动
            if (ds.HasChanges())
            {
                try
                {
                    da.Update(ds, "reader");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("信息修改失败！");//更新数据
                }
                finally
                {
                   data.close();
                }
            }
        }

      
    }
}
