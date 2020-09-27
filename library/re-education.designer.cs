namespace library
{
    partial class re_education
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
            this.educationlabel1 = new System.Windows.Forms.Label();
            this.educationlinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // educationlabel1
            // 
            this.educationlabel1.BackColor = System.Drawing.Color.Transparent;
            this.educationlabel1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.educationlabel1.Location = new System.Drawing.Point(48, 9);
            this.educationlabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.educationlabel1.Name = "educationlabel1";
            this.educationlabel1.Size = new System.Drawing.Size(516, 67);
            this.educationlabel1.TabIndex = 0;
            this.educationlabel1.Text = "读者入馆教育系统";
            this.educationlabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // educationlinkLabel1
            // 
            this.educationlinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.educationlinkLabel1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.educationlinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.educationlinkLabel1.Location = new System.Drawing.Point(226, 91);
            this.educationlinkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.educationlinkLabel1.Name = "educationlinkLabel1";
            this.educationlinkLabel1.Size = new System.Drawing.Size(148, 43);
            this.educationlinkLabel1.TabIndex = 1;
            this.educationlinkLabel1.TabStop = true;
            this.educationlinkLabel1.Text = "网址";
            this.educationlinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.educationlinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.educationlinkLabel1_LinkClicked);
            // 
            // re_education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.标;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 458);
            this.Controls.Add(this.educationlinkLabel1);
            this.Controls.Add(this.educationlabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "re_education";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入馆教育";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label educationlabel1;
        private System.Windows.Forms.LinkLabel educationlinkLabel1;
    }
}