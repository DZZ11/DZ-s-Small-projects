namespace library
{
    partial class add_admin
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
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtadno = new System.Windows.Forms.TextBox();
            this.联系方式 = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.读者姓名 = new System.Windows.Forms.Label();
            this.读者号 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(165, 223);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(125, 21);
            this.txttel.TabIndex = 12;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(165, 167);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(125, 21);
            this.txtpass.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(165, 111);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(125, 21);
            this.txtname.TabIndex = 8;
            // 
            // txtadno
            // 
            this.txtadno.Location = new System.Drawing.Point(165, 55);
            this.txtadno.Name = "txtadno";
            this.txtadno.Size = new System.Drawing.Size(125, 21);
            this.txtadno.TabIndex = 6;
            // 
            // 联系方式
            // 
            this.联系方式.AutoSize = true;
            this.联系方式.BackColor = System.Drawing.Color.Transparent;
            this.联系方式.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.联系方式.Location = new System.Drawing.Point(50, 223);
            this.联系方式.Name = "联系方式";
            this.联系方式.Size = new System.Drawing.Size(94, 21);
            this.联系方式.TabIndex = 11;
            this.联系方式.Text = "联系方式";
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.BackColor = System.Drawing.Color.Transparent;
            this.性别.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.Location = new System.Drawing.Point(50, 167);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(52, 21);
            this.性别.TabIndex = 9;
            this.性别.Text = "密码";
            // 
            // 读者姓名
            // 
            this.读者姓名.AutoSize = true;
            this.读者姓名.BackColor = System.Drawing.Color.Transparent;
            this.读者姓名.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者姓名.Location = new System.Drawing.Point(50, 111);
            this.读者姓名.Name = "读者姓名";
            this.读者姓名.Size = new System.Drawing.Size(52, 21);
            this.读者姓名.TabIndex = 7;
            this.读者姓名.Text = "姓名";
            // 
            // 读者号
            // 
            this.读者号.AutoSize = true;
            this.读者号.BackColor = System.Drawing.Color.Transparent;
            this.读者号.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者号.Location = new System.Drawing.Point(50, 55);
            this.读者号.Name = "读者号";
            this.读者号.Size = new System.Drawing.Size(73, 21);
            this.读者号.TabIndex = 5;
            this.读者号.Text = "管理号";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(213, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(38, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(399, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(542, 344);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "adno";
            this.Column1.HeaderText = "管理号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "adname";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "adpass";
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "adtel";
            this.Column4.HeaderText = "联系方式";
            this.Column4.Name = "Column4";
            // 
            // add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.标;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtadno);
            this.Controls.Add(this.联系方式);
            this.Controls.Add(this.性别);
            this.Controls.Add(this.读者姓名);
            this.Controls.Add(this.读者号);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "add_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加管理员";
            this.Load += new System.EventHandler(this.add_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtadno;
        private System.Windows.Forms.Label 联系方式;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.Label 读者姓名;
        private System.Windows.Forms.Label 读者号;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}