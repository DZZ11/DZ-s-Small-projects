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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad_login myForm = new ad_login();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r_login myForm = new r_login();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void 图书馆简介ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instruction my = new instruction();
            my.Show();
        }

        private void 读者须知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rnotice my = new rnotice();
            my.Show();
        }
    }
}
