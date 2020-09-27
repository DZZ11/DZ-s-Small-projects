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
    public partial class r_register : Form
    {
        public r_register()
        {
            InitializeComponent();
        }
       
        
        private void label3_Click(object sender, EventArgs e)
       {
        
        } 
        //读者注册
        private void r_registerbutton1_Click(object sender, EventArgs e)
           {
           
              
             //信息为空时提醒完善信息
            //if((r_registertextBox1.Text  == "")||( r_registertextBox2 .Text =="")||(r_registertextBox3 .Text =="")||(r_registertextBox4 .Text ==""))
            //  MessageBox.Show("请您完善信息","信息提示",MessageBoxButtons .OK );
            //账号,密码必填
               if (r_registertextBox1.Text  == "")
               {
                   MessageBox.Show("请输入账号");
                   r_registertextBox1.Focus();
                   return;
               }
               if (registertextBox5.Text == "")
               {
                   MessageBox.Show("请输入密码");
                   r_registertextBox2.Focus();
                   return;
               }
            //sql语句判断账号是否重复
              data.open();
            string rsql = string.Format("select readerno  from reader  where readerno=" + r_registertextBox1.Text + "");
            try
            {
                SqlCommand comm = new SqlCommand(rsql,data.com);

                //
                object result1 = comm.ExecuteScalar();//返回第一行第一列
                if (result1 != null)
                {
                   MessageBox.Show("该账号已被注册", "注册信息提示", MessageBoxButtons.OK);

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
           
           
            //添加个人信息
           // string strcon=("server=.;database=library;integrated security=true");
            //SqlConnection conn = new SqlConnection(strcon );
            //conn.Open();
            string readerno = this.r_registertextBox1.Text;
            string readerpass = this.registertextBox5.Text;
            string readertel = this.r_registertextBox4.Text;
               string readername = this.r_registertextBox2.Text;
               string readersex = this.r_registertextBox3.Text;
            string asql = string.Format("insert into reader values('{0}','{1}','{2}','{3}','{4}')",readerno ,readername ,readersex ,readertel,readerpass);
            try
            {
                SqlCommand comm1 = new SqlCommand(asql,data.com);
               data.open();
                int count = comm1.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("注册成功！");
                }

                else
                {
                    MessageBox.Show("注册失败！");
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
          
           
            //清空数据，提示注册成功
            r_registertextBox1.Text = "";
            r_registertextBox2.Text = "";
            r_registertextBox3.Text = "";
            r_registertextBox4.Text = "";
            registertextBox5.Text = "";
            //MessageBox.Show("注册成功！");
            //this.Close();//关闭该页面
           }
        //重置信息
        private void registerbutton2_Click(object sender, EventArgs e)
        {
            r_registertextBox1.Text = "";
            r_registertextBox2 .Text = "";
            r_registertextBox3.Text = "";
            r_registertextBox4.Text = "";
            registertextBox5.Text = "";
            
        }

       
        //退出程序
        private void registerbutton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void r_registertextBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}


