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
    public partial class find : Form
    {
        public find()
        {
            InitializeComponent();
        }
        DataView mydv = new DataView();
        DataSet ds = new DataSet();
        //更新数据库
        SqlDataAdapter da;

        private void find_Load(object sender, EventArgs e)
        {
            string mystr;
            SqlConnection myconn = new SqlConnection();
            DataSet myds = new DataSet();
            DataSet myds1 = new DataSet();
            mystr = "Data Source=.;Initial Catalog=library;integrated security=true";
            myconn.ConnectionString = mystr;
            myconn.Open();
            SqlDataAdapter myda = new SqlDataAdapter("select" + " * from book", myconn);
            myda.Fill(myds, "book");
            mydv = myds.Tables["book"].DefaultView;
            //绑定combobox1s数据
            SqlDataAdapter myda1 = new SqlDataAdapter("select distinct bookcategory from book", myconn);
            comboBox1.Items.Add("成人类");
            comboBox1.Items.Add("儿童类");
            //以下设置dgvbook的属性
            dgvbook.DataSource = mydv;
            dgvbook.GridColor = Color.RoyalBlue;
            dgvbook.ScrollBars = ScrollBars.Both;
            dgvbook.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvbook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbook.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbook.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbook.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbook.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvbook.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            myconn.Close();
            txtbname.Text = "";
            txtbauthor.Text = "";
            comboBox1.Text = "";
            //// TODO: 这行代码将数据加载到表“libraryDataSet4.book”中。您可以根据需要移动或删除它。
            //this.bookTableAdapter1.Fill(this.libraryDataSet4.book);
            //// TODO: 这行代码将数据加载到表“libraryDataSet1.book”中。您可以根据需要移动或删除它。
            //this.bookTableAdapter.Fill(this.libraryDataSet1.book);
            //string sql = "select * from book";
            //zzz(sql);
        }
        private void zzz(string sql)
        {
            ds.Clear();
            da = new SqlDataAdapter(sql, data.com);
            da.Fill(ds, "book");
            dgvbook.DataSource = ds.Tables["book"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condstr = "";
            //
            if (txtbname.Text != "")
            {
                condstr = " bookname like '%" + txtbname.Text + "%'";
            }
            if (txtbauthor.Text != "")
            {
                if (condstr != "")
                {
                    condstr = condstr + " and author like '%" + txtbauthor.Text + "%'";
                }
                else
                    condstr = " author like'%" + txtbauthor.Text + "%'";
            }
            if (comboBox1.Text != "")
            {
                if (condstr != "")
                {
                    condstr = condstr + " and bookcategory = '" + comboBox1.Text + "'";
                }
                else
                    condstr = " bookcategory = '" + comboBox1.Text + "'";
            }
            mydv.RowFilter = condstr;//过滤记录
            //string bookname = this.txtbname.Text;
            //string author = this.txtbauthor.Text;
            //string sql = "select bookno,bookname,author,press,number from book where 1=1";
            //if (bookname != "")
            //{
            //    sql += string.Format("and bookname like '%{0}%'",bookname);
            //}
            //if (author != "")
            //{
            //    sql += string.Format(" and author like '%{0}%'",author);
            //}
            //zzz(sql);
            //DBHelper.closedb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbname.Text = "";
            txtbauthor.Text = "";
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string orderstr = "";
            ////根据用户输入求得排序条件表达式
            //if (comboBox2.Text != "")
            //{
            //    if (radioButton1.Checked)
            //    {
            //        comboBox2.Text

            //        orderstr = comboBox2.Text + "ASC";
            //    }
            //    else
            //        orderstr = comboBox2.Text + "DESC";
            //    mydv.Sort = orderstr;//记录排序
           
        }
    }
}
