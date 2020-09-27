namespace library
{
    partial class 添加图书信息
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.图书号 = new System.Windows.Forms.Label();
            this.txtbookno = new System.Windows.Forms.TextBox();
            this.图书名 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.作者 = new System.Windows.Forms.Label();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.出版社 = new System.Windows.Forms.Label();
            this.txtpress = new System.Windows.Forms.TextBox();
            this.图书库存 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet2 = new library.libraryDataSet2();
            this.bookTableAdapter = new library.libraryDataSet2TableAdapters.bookTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookcategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadd.Location = new System.Drawing.Point(44, 361);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 31);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "确认添加";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel.Location = new System.Drawing.Point(218, 361);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(95, 31);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // 图书号
            // 
            this.图书号.AutoSize = true;
            this.图书号.BackColor = System.Drawing.Color.Transparent;
            this.图书号.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.图书号.Location = new System.Drawing.Point(43, 58);
            this.图书号.Name = "图书号";
            this.图书号.Size = new System.Drawing.Size(73, 21);
            this.图书号.TabIndex = 2;
            this.图书号.Text = "图书号";
            // 
            // txtbookno
            // 
            this.txtbookno.Location = new System.Drawing.Point(159, 58);
            this.txtbookno.Name = "txtbookno";
            this.txtbookno.Size = new System.Drawing.Size(142, 21);
            this.txtbookno.TabIndex = 1;
            // 
            // 图书名
            // 
            this.图书名.AutoSize = true;
            this.图书名.BackColor = System.Drawing.Color.Transparent;
            this.图书名.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.图书名.Location = new System.Drawing.Point(43, 108);
            this.图书名.Name = "图书名";
            this.图书名.Size = new System.Drawing.Size(73, 21);
            this.图书名.TabIndex = 2;
            this.图书名.Text = "图书名";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(159, 109);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(142, 21);
            this.txtbookname.TabIndex = 2;
            // 
            // 作者
            // 
            this.作者.AutoSize = true;
            this.作者.BackColor = System.Drawing.Color.Transparent;
            this.作者.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.作者.Location = new System.Drawing.Point(43, 156);
            this.作者.Name = "作者";
            this.作者.Size = new System.Drawing.Size(0, 21);
            this.作者.TabIndex = 2;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(159, 160);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(142, 21);
            this.txtauthor.TabIndex = 3;
            // 
            // 出版社
            // 
            this.出版社.AutoSize = true;
            this.出版社.BackColor = System.Drawing.Color.Transparent;
            this.出版社.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出版社.Location = new System.Drawing.Point(43, 208);
            this.出版社.Name = "出版社";
            this.出版社.Size = new System.Drawing.Size(73, 21);
            this.出版社.TabIndex = 2;
            this.出版社.Text = "出版社";
            // 
            // txtpress
            // 
            this.txtpress.Location = new System.Drawing.Point(159, 211);
            this.txtpress.Name = "txtpress";
            this.txtpress.Size = new System.Drawing.Size(142, 21);
            this.txtpress.TabIndex = 4;
            // 
            // 图书库存
            // 
            this.图书库存.AutoSize = true;
            this.图书库存.BackColor = System.Drawing.Color.Transparent;
            this.图书库存.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.图书库存.Location = new System.Drawing.Point(43, 258);
            this.图书库存.Name = "图书库存";
            this.图书库存.Size = new System.Drawing.Size(94, 21);
            this.图书库存.TabIndex = 2;
            this.图书库存.Text = "图书库存";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(159, 262);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(142, 21);
            this.txtnumber.TabIndex = 5;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "作者";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booknoDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.pressDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.bookBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(339, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(637, 390);
            this.dataGridView1.TabIndex = 10;
            // 
            // booknoDataGridViewTextBoxColumn
            // 
            this.booknoDataGridViewTextBoxColumn.DataPropertyName = "bookno";
            this.booknoDataGridViewTextBoxColumn.HeaderText = "图书号";
            this.booknoDataGridViewTextBoxColumn.Name = "booknoDataGridViewTextBoxColumn";
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "图书名";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // pressDataGridViewTextBoxColumn
            // 
            this.pressDataGridViewTextBoxColumn.DataPropertyName = "press";
            this.pressDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.pressDataGridViewTextBoxColumn.Name = "pressDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "图书库存";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bookcategory";
            this.Column1.HeaderText = "图书分类";
            this.Column1.Name = "Column1";
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "book";
            this.bookBindingSource1.DataSource = this.libraryDataSet2;
            // 
            // libraryDataSet2
            // 
            this.libraryDataSet2.DataSetName = "libraryDataSet2";
            this.libraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(43, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "图书分类";
            // 
            // txtbookcategory
            // 
            this.txtbookcategory.Location = new System.Drawing.Point(159, 321);
            this.txtbookcategory.Name = "txtbookcategory";
            this.txtbookcategory.Size = new System.Drawing.Size(142, 21);
            this.txtbookcategory.TabIndex = 6;
            // 
            // 添加图书信息
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.标;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(1002, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbookcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.图书库存);
            this.Controls.Add(this.txtpress);
            this.Controls.Add(this.出版社);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.作者);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.图书名);
            this.Controls.Add(this.txtbookno);
            this.Controls.Add(this.图书号);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "添加图书信息";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加图书信息";
            this.Load += new System.EventHandler(this.addbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label 图书号;
        private System.Windows.Forms.TextBox txtbookno;
        private System.Windows.Forms.Label 图书名;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label 作者;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Label 出版社;
        private System.Windows.Forms.TextBox txtpress;
        private System.Windows.Forms.Label 图书库存;
        private System.Windows.Forms.TextBox txtnumber;
      //  private libraryDataSet  libraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
      //  private libraryDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private libraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private libraryDataSet2TableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbookcategory;
    }
}