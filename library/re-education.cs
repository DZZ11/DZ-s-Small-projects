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
    public partial class re_education : Form
    {
        public re_education()
        {
            InitializeComponent();
        }
        //入馆教育
        private void educationlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception )
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
           educationlinkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
           System.Diagnostics.Process.Start("http://lib.zut.edu.cn/");
            

        }

      
    }
}
