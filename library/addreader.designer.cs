namespace library
{
    partial class addreader
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
            this.components = new System.ComponentModel.Container();
            this.读者号 = new System.Windows.Forms.Label();
            this.读者姓名 = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.联系方式 = new System.Windows.Forms.Label();
            this.txtreaderno = new System.Windows.Forms.TextBox();
            this.txtreadername = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtreaderpass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet2 = new library.libraryDataSet2();
            this.readerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new library.libraryDataSet2TableAdapters.readerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // 读者号
            // 
            this.读者号.AutoSize = true;
            this.读者号.BackColor = System.Drawing.Color.Transparent;
            this.读者号.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者号.Location = new System.Drawing.Point(56, 50);
            this.读者号.Name = "读者号";
            this.读者号.Size = new System.Drawing.Size(73, 21);
            this.读者号.TabIndex = 0;
            this.读者号.Text = "读者号";
            // 
            // 读者姓名
            // 
            this.读者姓名.AutoSize = true;
            this.读者姓名.BackColor = System.Drawing.Color.Transparent;
            this.读者姓名.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者姓名.Location = new System.Drawing.Point(56, 106);
            this.读者姓名.Name = "读者姓名";
            this.读者姓名.Size = new System.Drawing.Size(94, 21);
            this.读者姓名.TabIndex = 1;
            this.读者姓名.Text = "读者姓名";
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.BackColor = System.Drawing.Color.Transparent;
            this.性别.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.Location = new System.Drawing.Point(56, 162);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(52, 21);
            this.性别.TabIndex = 2;
            this.性别.Text = "性别";
            // 
            // 联系方式
            // 
            this.联系方式.AutoSize = true;
            this.联系方式.BackColor = System.Drawing.Color.Transparent;
            this.联系方式.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.联系方式.Location = new System.Drawing.Point(56, 218);
            this.联系方式.Name = "联系方式";
            this.联系方式.Size = new System.Drawing.Size(94, 21);
            this.联系方式.TabIndex = 3;
            this.联系方式.Text = "联系方式";
            // 
            // txtreaderno
            // 
            this.txtreaderno.Location = new System.Drawing.Point(171, 50);
            this.txtreaderno.Name = "txtreaderno";
            this.txtreaderno.Size = new System.Drawing.Size(125, 21);
            this.txtreaderno.TabIndex = 1;
            // 
            // txtreadername
            // 
            this.txtreadername.Location = new System.Drawing.Point(171, 106);
            this.txtreadername.Name = "txtreadername";
            this.txtreadername.Size = new System.Drawing.Size(125, 21);
            this.txtreadername.TabIndex = 2;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(171, 162);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(125, 21);
            this.txtsex.TabIndex = 3;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(171, 218);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(125, 21);
            this.txttel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(40, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(196, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(56, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "读者密码";
            // 
            // txtreaderpass
            // 
            this.txtreaderpass.Location = new System.Drawing.Point(171, 274);
            this.txtreaderpass.Name = "txtreaderpass";
            this.txtreaderpass.Size = new System.Drawing.Size(125, 21);
            this.txtreaderpass.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.readerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(344, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 344);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "readerno";
            this.dataGridViewTextBoxColumn1.HeaderText = "读者号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "readername";
            this.dataGridViewTextBoxColumn2.HeaderText = "读者名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tel";
            this.dataGridViewTextBoxColumn4.HeaderText = "电话";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "readerpass";
            this.dataGridViewTextBoxColumn5.HeaderText = "读者密码";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // readerBindingSource2
            // 
            this.readerBindingSource2.DataMember = "reader";
            this.readerBindingSource2.DataSource = this.libraryDataSet2;
            // 
            // libraryDataSet2
            // 
            this.libraryDataSet2.DataSetName = "libraryDataSet2";
            this.libraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource1
            // 
            this.readerBindingSource1.DataMember = "reader";
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // addreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.壁纸;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtreaderpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtreadername);
            this.Controls.Add(this.txtreaderno);
            this.Controls.Add(this.联系方式);
            this.Controls.Add(this.性别);
            this.Controls.Add(this.读者姓名);
            this.Controls.Add(this.读者号);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "addreader";
            this.Text = "添加读者信息";
            this.Load += new System.EventHandler(this.addreader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 读者号;
        private System.Windows.Forms.Label 读者姓名;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.Label 联系方式;
        private System.Windows.Forms.TextBox txtreaderno;
        private System.Windows.Forms.TextBox txtreadername;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
      //  private libraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource readerBindingSource;
        //    private libraryDataSet2TableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreaderpass;
        private System.Windows.Forms.DataGridView dataGridView1;
       /* private libraryDataSet1 libraryDataSet1;*/
        private System.Windows.Forms.BindingSource readerBindingSource1;
       // private libraryDataSet1TableAdapters.readerTableAdapter readerTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn readernoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn readernameDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn readerpassDataGridViewTextBoxColumn;
        private libraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource readerBindingSource2;
        private libraryDataSet2TableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}