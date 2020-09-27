namespace library
{
    partial class re_news
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newslistBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newslistBox1
            // 
            this.newslistBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.newslistBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newslistBox1.FormattingEnabled = true;
            this.newslistBox1.ItemHeight = 22;
            this.newslistBox1.Items.AddRange(new object[] {
            "       ",
            "",
            "      关于举办“精品图书进校园”活动的通知",
            "",
            "   为进一步激发师生读书热情，活跃校园文化，提升素质教育，",
            "   培养大学生良好的阅读习惯，满足师生科学研究、学习的需求，",
            "   我校读书节组委会将联合北京友林文化发展限公司举办2017“精",
            "   品图书进校园”活动。活动将展出经典名著、畅销书、人物传记、",
            "   文学作品、励志图书、英语四六级等类型图书，欢迎广大读者前",
            "   往浏览、阅读。",
            "",
            "   时间: 2017年11 月23日--/1月30日",
            "",
            "   地点:  图书馆一楼服务大厅"});
            this.newslistBox1.Location = new System.Drawing.Point(1, -4);
            this.newslistBox1.Margin = new System.Windows.Forms.Padding(2);
            this.newslistBox1.Name = "newslistBox1";
            this.newslistBox1.Size = new System.Drawing.Size(745, 466);
            this.newslistBox1.TabIndex = 0;
            // 
            // re_news
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(743, 457);
            this.Controls.Add(this.newslistBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "re_news";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "最新公告";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox newslistBox1;
    }
}