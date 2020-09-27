namespace library
{
    partial class re_changinformation
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
            this.changeinfrdataGridView1 = new System.Windows.Forms.DataGridView();
            this.readernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet6 = new library.libraryDataSet6();
            this.changebutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeinfrdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // changeinfrdataGridView1
            // 
            this.changeinfrdataGridView1.AutoGenerateColumns = false;
            this.changeinfrdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changeinfrdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readernoDataGridViewTextBoxColumn,
            this.readernameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.readerpassDataGridViewTextBoxColumn});
            this.changeinfrdataGridView1.DataSource = this.readerBindingSource;
            this.changeinfrdataGridView1.Location = new System.Drawing.Point(2, 10);
            this.changeinfrdataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.changeinfrdataGridView1.Name = "changeinfrdataGridView1";
            this.changeinfrdataGridView1.RowTemplate.Height = 27;
            this.changeinfrdataGridView1.Size = new System.Drawing.Size(898, 289);
            this.changeinfrdataGridView1.TabIndex = 0;
            // 
            // readernoDataGridViewTextBoxColumn
            // 
            this.readernoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readernoDataGridViewTextBoxColumn.DataPropertyName = "readerno";
            this.readernoDataGridViewTextBoxColumn.HeaderText = "账号";
            this.readernoDataGridViewTextBoxColumn.Name = "readernoDataGridViewTextBoxColumn";
            // 
            // readernameDataGridViewTextBoxColumn
            // 
            this.readernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readernameDataGridViewTextBoxColumn.DataPropertyName = "readername";
            this.readernameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.readernameDataGridViewTextBoxColumn.Name = "readernameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "电话";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // readerpassDataGridViewTextBoxColumn
            // 
            this.readerpassDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readerpassDataGridViewTextBoxColumn.DataPropertyName = "readerpass";
            this.readerpassDataGridViewTextBoxColumn.HeaderText = "密码";
            this.readerpassDataGridViewTextBoxColumn.Name = "readerpassDataGridViewTextBoxColumn";
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            this.readerBindingSource.DataSource = this.libraryDataSet6;
            // 
            // libraryDataSet6
            // 
            this.libraryDataSet6.DataSetName = "libraryDataSet6";
            this.libraryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // changebutton1
            // 
            this.changebutton1.BackColor = System.Drawing.Color.Transparent;
            this.changebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changebutton1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changebutton1.Location = new System.Drawing.Point(408, 383);
            this.changebutton1.Name = "changebutton1";
            this.changebutton1.Size = new System.Drawing.Size(86, 32);
            this.changebutton1.TabIndex = 1;
            this.changebutton1.Text = "修改";
            this.changebutton1.UseVisualStyleBackColor = false;
            this.changebutton1.Click += new System.EventHandler(this.changebutton1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(170, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "请您直接在表中修改自己的信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // re_changinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.壁纸;
            this.ClientSize = new System.Drawing.Size(899, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changebutton1);
            this.Controls.Add(this.changeinfrdataGridView1);
            this.MaximizeBox = false;
            this.Name = "re_changinformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改个人信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.re_changinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.changeinfrdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
        }
           // ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).EndInit();
            //this.ResumeLayout(false);

        //}
            //((System.ComponentModel.ISupportInitialize)(this.libraryDataSet6)).EndInit();
          //  this.ResumeLayout(false);

        //}

        #endregion

        private System.Windows.Forms.DataGridView changeinfrdataGridView1;
        private System.Windows.Forms.Button changebutton1;
        private libraryDataSet6 libraryDataSet6;
        private System.Windows.Forms.BindingSource readerBindingSource;
        // private libraryDataSet6TableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn readernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerpassDataGridViewTextBoxColumn;
    }
}