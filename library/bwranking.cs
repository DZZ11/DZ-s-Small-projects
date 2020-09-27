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
    public partial class bwranking : Form
    {
        public bwranking()
        {
            InitializeComponent();
        }

        private void bwranking_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("\t\t借阅排行榜");
            listBox1.Items.Add("书名\t借阅数量");
            listBox1.Items.Add("==================");
            listBox2.Items.Add("\t\t借阅排行榜");
            listBox2.Items.Add("书名\t借阅数量");
            listBox2.Items.Add("==================");
            //string sql = "Data Source=.;Initial Catalog=library;integrated security=true";
            //SqlConnection conn = new SqlConnection(sql);
            //DataSet myds = new DataSet();
            //conn.Open();
            
            //if (radioButton1.Checked)
            //{
            //    string sqd = "select bookname,borrownumeber from book order by borrownumeber desc";
            //    SqlCommand cmd = new SqlCommand(sqd, conn);
            //    SqlDataReader desc = cmd.ExecuteReader();
            //    while (desc.Read())
            //    {
            //        listBox1.Items.Add(string.Format("{0}\t{1}", desc[0].ToString(), desc[1].ToString()));
            //    }
            //    desc.Close();
            //}
            //else
            //{
            //    string sq = "select bookname,borrownumeber from book order by borrownumeber ASC";
            //    SqlCommand cmn = new SqlCommand(sq, conn);
            //    SqlDataReader asc = cmn.ExecuteReader();
            //    while (asc.Read())
            //    {
            //        listBox1.Items.Add(string.Format("{0}\t{1}", asc[0].ToString(), asc[1].ToString()));
            //    }
            //    asc.Close();
            //}
            //conn.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Data Source=.;Initial Catalog=library;integrated security=true";
            SqlConnection conn = new SqlConnection(sql);
            DataSet myds = new DataSet();
            conn.Open();

            if (radioButton1.Checked)
            {
                string sqd = "select bookname,borrownumeber from book order by borrownumeber desc";
                SqlCommand cmd = new SqlCommand(sqd, conn);
                SqlDataReader desc = cmd.ExecuteReader();
                while (desc.Read())
                {
                    listBox1.Items.Add(string.Format("{0}\t{1}", desc[0].ToString(), desc[1].ToString()));
                }
                desc.Close();
            }
            else
            {
                string sq = "select bookname,borrownumeber from book order by borrownumeber ASC";
                SqlCommand cmn = new SqlCommand(sq, conn);
                SqlDataReader asc = cmn.ExecuteReader();
                while (asc.Read())
                {
                    listBox2.Items.Add(string.Format("{0}\t{1}", asc[0].ToString(), asc[1].ToString()));
                }
                asc.Close();
            }
            
            conn.Close();
        }
        //listBox1.Items.Clear();
    }
}
