namespace library
{
    partial class re_codelookbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(re_codelookbook));
            this.codebooklabel1 = new System.Windows.Forms.Label();
            this.codebookpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.codebookpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codebooklabel1
            // 
            this.codebooklabel1.BackColor = System.Drawing.Color.Transparent;
            this.codebooklabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.codebooklabel1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.codebooklabel1.ForeColor = System.Drawing.Color.Black;
            this.codebooklabel1.Location = new System.Drawing.Point(683, 196);
            this.codebooklabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codebooklabel1.Name = "codebooklabel1";
            this.codebooklabel1.Size = new System.Drawing.Size(190, 43);
            this.codebooklabel1.TabIndex = 1;
            this.codebooklabel1.Text = "请您扫码后查看书籍";
            this.codebooklabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.codebooklabel1.Click += new System.EventHandler(this.codebooklabel1_Click);
            // 
            // codebookpictureBox1
            // 
            this.codebookpictureBox1.BackgroundImage = global::library.Properties.Resources.img_d4b06b2bc6f296091e4cbdb38b9aa02d;
            this.codebookpictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.codebookpictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codebookpictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("codebookpictureBox1.Image")));
            this.codebookpictureBox1.Location = new System.Drawing.Point(0, 0);
            this.codebookpictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.codebookpictureBox1.Name = "codebookpictureBox1";
            this.codebookpictureBox1.Size = new System.Drawing.Size(914, 599);
            this.codebookpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codebookpictureBox1.TabIndex = 0;
            this.codebookpictureBox1.TabStop = false;
            // 
            // re_codelookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 599);
            this.Controls.Add(this.codebooklabel1);
            this.Controls.Add(this.codebookpictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "re_codelookbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫码看书";
            ((System.ComponentModel.ISupportInitialize)(this.codebookpictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox codebookpictureBox1;
        private System.Windows.Forms.Label codebooklabel1;

    }
}