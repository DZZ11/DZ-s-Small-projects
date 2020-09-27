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
    public partial class rpersonalview : Form
    {
        public rpersonalview()
        {
            InitializeComponent();
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
        rpvdataGridView .DataSource = ds.Tables["reader"];

        }
        
        //datagridview
        private void r_personal_view_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet5.reader”中。您可以根据需要移动或删除它。
            //this.readerTableAdapter1.Fill(this.libraryDataSet5.reader);
            string sql = "select * from reader where readerno='"+r_login.rn+"'";
            showinfo(sql);
        }
        //点击按钮查询个人信息
       /* private void rpvbutton1_Click(object sender, EventArgs e)
        {
            //连接数据库
            // Formtransfer.myno = int.Parse(rpvtextBox1 .Text );
            //rpersonalview myform = new r_login();
            // myform.ShowDialog();
            string sql = string.Format("select * from reader where 1=1");
            sql += string.Format(" and readerno like '%{0}%' ", r_login.rn);

            showinfo(sql);
        }*/
               /* try
                {
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                    DBHelper.opendb();
                    SqlDataReader datareader = comm.ExecuteReader();
                    while (datareader.Read())
                    {

                        string readerpass = datareader["readerpass"].ToString();
                        string readertel = datareader["tel"].ToString();
                        string readername = datareader["readername"].ToString();
                        string readerage = datareader["readerage"].ToString();

                    }
                    comm.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    DBHelper.closedb();
                }
            }*/
            
            //读者根据账号查询个人信息
        //   if (readerno == "")
           
        //    {
        //        MessageBox.Show("请您再次输入账号！");
        //        rpvtextBox1.Focus();
        //        return;
        //    }
            
           
        //}
        //修改个人信息
       /* private void rpvbutton2_Click(object sender, EventArgs e)
        {
            
            
            string readerpass = rpvtextBox2.Text;
            string readertel = rpvtextBox3.Text;
            //修改信息
            string sql = string.Format("update reader set readerpass='"+rpvtextBox2 .Text+ "',tel='"+rpvtextBox3 .Text +"' where 1=1");
            //if (readerno  != "")
            //{

                sql += string.Format(" and  readerno like '%{0}%'", r_login.rn);

            //}*/

           // showinfo(sql);
            //显示修改后的信息
           //string sql1= string.Format("select * from reader where readerno like '%{0}%'", r_login.rn );
          // showinfo(sql1);
            //if (readerno  == "")
            //{
            //    MessageBox.Show("请您再次输入账号！");
            //    rpvtextBox1.Focus();
            //    return;
            //}

        }
         
            
}
    

