namespace library
{
    partial class re_open_class
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
            this.openclasslinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // openclasslinkLabel1
            // 
            this.openclasslinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.openclasslinkLabel1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openclasslinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.openclasslinkLabel1.Location = new System.Drawing.Point(141, 57);
            this.openclasslinkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openclasslinkLabel1.Name = "openclasslinkLabel1";
            this.openclasslinkLabel1.Size = new System.Drawing.Size(160, 47);
            this.openclasslinkLabel1.TabIndex = 0;
            this.openclasslinkLabel1.TabStop = true;
            this.openclasslinkLabel1.Text = "视频网址";
            this.openclasslinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openclasslinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // re_open_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.标;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 322);
            this.Controls.Add(this.openclasslinkLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "re_open_class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公开课";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel openclasslinkLabel1;
    }
}