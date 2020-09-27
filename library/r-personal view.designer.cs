namespace library
{
    partial class rpersonalview
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
            this.libraryDataSet = new library.libraryDataSet();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new library.libraryDataSetTableAdapters.readerTableAdapter();
            this.rpvdataGridView = new System.Windows.Forms.DataGridView();
            this.readernoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet5 = new library.libraryDataSet5();
            this.readerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.readerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new library.libraryDataSet1();
            this.libraryDataSet4 = new library.libraryDataSet4();
            this.readerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter1 = new library.libraryDataSet5TableAdapters.readerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpvdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            this.readerBindingSource.DataSource = this.libraryDataSet;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // rpvdataGridView
            // 
            this.rpvdataGridView.AutoGenerateColumns = false;
            this.rpvdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rpvdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readernoDataGridViewTextBoxColumn,
            this.readernameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.readerpassDataGridViewTextBoxColumn});
            this.rpvdataGridView.DataSource = this.readerBindingSource4;
            this.rpvdataGridView.Location = new System.Drawing.Point(30, 33);
            this.rpvdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.rpvdataGridView.Name = "rpvdataGridView";
            this.rpvdataGridView.RowTemplate.Height = 27;
            this.rpvdataGridView.Size = new System.Drawing.Size(661, 394);
            this.rpvdataGridView.TabIndex = 2;
            // 
            // readernoDataGridViewTextBoxColumn
            // 
            this.readernoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readernoDataGridViewTextBoxColumn.DataPropertyName = "readerno";
            this.readernoDataGridViewTextBoxColumn.HeaderText = "读者号";
            this.readernoDataGridViewTextBoxColumn.Name = "readernoDataGridViewTextBoxColumn";
            // 
            // readernameDataGridViewTextBoxColumn
            // 
            this.readernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readernameDataGridViewTextBoxColumn.DataPropertyName = "readername";
            this.readernameDataGridViewTextBoxColumn.HeaderText = "读者名";
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
            this.readerpassDataGridViewTextBoxColumn.HeaderText = "读者密码";
            this.readerpassDataGridViewTextBoxColumn.Name = "readerpassDataGridViewTextBoxColumn";
            // 
            // readerBindingSource4
            // 
            this.readerBindingSource4.DataMember = "reader";
            this.readerBindingSource4.DataSource = this.libraryDataSet5;
            // 
            // libraryDataSet5
            // 
            this.libraryDataSet5.DataSetName = "libraryDataSet5";
            this.libraryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource3
            // 
            this.readerBindingSource3.DataMember = "reader";
            // 
            // readerBindingSource1
            // 
            this.readerBindingSource1.DataMember = "reader";
            this.readerBindingSource1.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "libraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSet4
            // 
            this.libraryDataSet4.DataSetName = "libraryDataSet4";
            this.libraryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource2
            // 
            this.readerBindingSource2.DataMember = "reader";
            this.readerBindingSource2.DataSource = this.libraryDataSet4;
            // 
            // readerTableAdapter1
            // 
            this.readerTableAdapter1.ClearBeforeFill = true;
            // 
            // rpersonalview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.壁纸;
            this.ClientSize = new System.Drawing.Size(713, 438);
            this.Controls.Add(this.rpvdataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "rpersonalview";
            this.Text = "我的信息";
            this.Load += new System.EventHandler(this.r_personal_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpvdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.readerBindingSource2)).EndInit();
            //this.ResumeLayout(false);

        }
           // ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource2)).EndInit();
           // this.ResumeLayout(false);
           // this.PerformLayout();

       // }
           // ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).EndInit();
            ///((System.ComponentModel.ISupportInitialize)(this.readerBindingSource2)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet5)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.readerBindingSource4)).EndInit();
           // this.ResumeLayout(false);
            //this.PerformLayout();

       // }

        #endregion

        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private libraryDataSetTableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.DataGridView rpvdataGridView;
        private libraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource readerBindingSource1;
        //private libraryDataSet1TableAdapters.readerTableAdapter readerTableAdapter1;
        private libraryDataSet4 libraryDataSet4;
        private System.Windows.Forms.BindingSource readerBindingSource2;
      //  private libraryDataSet4TableAdapters.readerTableAdapter readerTableAdapter2;
       // private libraryDataSet5 libraryDataSet5;
        private System.Windows.Forms.BindingSource readerBindingSource3;
        // private libraryDataSet5TableAdapters.readerTableAdapter readerTableAdapter3;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn readernoDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn readernameDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        // private System.Windows.Forms.DataGridViewTextBoxColumn readerpassDataGridViewTextBoxColumn;
        private libraryDataSet5 libraryDataSet5;
        private System.Windows.Forms.BindingSource readerBindingSource4;
        private libraryDataSet5TableAdapters.readerTableAdapter readerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn readernoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerpassDataGridViewTextBoxColumn;

    }
}