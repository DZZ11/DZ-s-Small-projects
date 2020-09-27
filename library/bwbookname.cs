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
    public partial class bwbookname : Form
    {
        public bwbookname()
        {
            InitializeComponent();
        }

        private void bwbookname_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=.;Initial Catalog=library;integrated security=true";
            SqlConnection conn = new SqlConnection(sql);
            DataSet myds = new DataSet();
            conn.Open();
            string sqd = "select book.bookname,borrow.borrowtime,borrow.returntime from book,borrow where borrow.b_readerno='" + r_login.rn + "' and book.bookno=borrow.b_bookno";
            SqlCommand cmd = new SqlCommand(sqd, conn);
            SqlDataReader myreader = cmd.ExecuteReader();
            listBox1.Items.Add("书名\t\t借出时间\t\t借入时间");
            listBox1.Items.Add("================================================");
            while (myreader.Read())
            {
                listBox1.Items.Add(string.Format("{0}\t{1}\t{2}", myreader[0].ToString(), myreader[1].ToString(), myreader[2].ToString()));
            }
            conn.Close();
            myreader.Close();
        }
    }
}
