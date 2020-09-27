using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class bookmanageSK : Form
    {
        public bookmanageSK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D://文件//library//library//picture//书屋管理制度.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D://文件//library//library//picture//图书管理员岗位职责.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D://文件//library//library//picture//读者阅览制度.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D://文件//library//library//picture//图书赔偿制度.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
