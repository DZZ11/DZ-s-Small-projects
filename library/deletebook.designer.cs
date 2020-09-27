namespace library
{
    partial class deletebook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.按图书号删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按图书名删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按作者名删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按出版社删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按图书号删除ToolStripMenuItem,
            this.按图书名删除ToolStripMenuItem,
            this.按作者名删除ToolStripMenuItem,
            this.按出版社删除ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 按图书号删除ToolStripMenuItem
            // 
            this.按图书号删除ToolStripMenuItem.Name = "按图书号删除ToolStripMenuItem";
            this.按图书号删除ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.按图书号删除ToolStripMenuItem.Text = "按图书号删除";
            this.按图书号删除ToolStripMenuItem.Click += new System.EventHandler(this.按图书号删除ToolStripMenuItem_Click);
            // 
            // 按图书名删除ToolStripMenuItem
            // 
            this.按图书名删除ToolStripMenuItem.Name = "按图书名删除ToolStripMenuItem";
            this.按图书名删除ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.按图书名删除ToolStripMenuItem.Text = "按图书名删除";
            this.按图书名删除ToolStripMenuItem.Click += new System.EventHandler(this.按图书名删除ToolStripMenuItem_Click);
            // 
            // 按作者名删除ToolStripMenuItem
            // 
            this.按作者名删除ToolStripMenuItem.Name = "按作者名删除ToolStripMenuItem";
            this.按作者名删除ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.按作者名删除ToolStripMenuItem.Text = "按作者名删除";
            this.按作者名删除ToolStripMenuItem.Click += new System.EventHandler(this.按作者名删除ToolStripMenuItem_Click);
            // 
            // 按出版社删除ToolStripMenuItem
            // 
            this.按出版社删除ToolStripMenuItem.Name = "按出版社删除ToolStripMenuItem";
            this.按出版社删除ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.按出版社删除ToolStripMenuItem.Text = "按出版社删除";
            this.按出版社删除ToolStripMenuItem.Click += new System.EventHandler(this.按出版社删除ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // deletebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.标;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 581);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "deletebook";
            this.Text = "删除图书信息";
            this.Load += new System.EventHandler(this.deletebook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 按图书号删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按图书名删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按作者名删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按出版社删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}