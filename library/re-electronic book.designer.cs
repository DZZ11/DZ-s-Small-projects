namespace library
{
    partial class re_electronic_book
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
            this.electronicbooklabel1 = new System.Windows.Forms.Label();
            this.electroniclinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // electronicbooklabel1
            // 
            this.electronicbooklabel1.BackColor = System.Drawing.Color.Transparent;
            this.electronicbooklabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.electronicbooklabel1.Location = new System.Drawing.Point(311, 42);
            this.electronicbooklabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.electronicbooklabel1.Name = "electronicbooklabel1";
            this.electronicbooklabel1.Size = new System.Drawing.Size(152, 18);
            this.electronicbooklabel1.TabIndex = 0;
            this.electronicbooklabel1.Text = "更多电子书尽在其内";
            this.electronicbooklabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.electronicbooklabel1.Click += new System.EventHandler(this.electronicbooklabel1_Click);
            // 
            // electroniclinkLabel1
            // 
            this.electroniclinkLabel1.AutoSize = true;
            this.electroniclinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.electroniclinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.electroniclinkLabel1.Location = new System.Drawing.Point(350, 117);
            this.electroniclinkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.electroniclinkLabel1.Name = "electroniclinkLabel1";
            this.electroniclinkLabel1.Size = new System.Drawing.Size(65, 12);
            this.electroniclinkLabel1.TabIndex = 1;
            this.electroniclinkLabel1.TabStop = true;
            this.electroniclinkLabel1.Text = "电子书网址";
            this.electroniclinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // re_electronic_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.标;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 513);
            this.Controls.Add(this.electroniclinkLabel1);
            this.Controls.Add(this.electronicbooklabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "re_electronic_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label electronicbooklabel1;
        private System.Windows.Forms.LinkLabel electroniclinkLabel1;
    }
}