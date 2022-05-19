namespace QuanLyPhongMach
{
    partial class TraCuuDonThuoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sttDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienThuocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongMachDataSet = new QuanLyPhongMach.QuanLyPhongMachDataSet();
            this.donThuocTableAdapter = new QuanLyPhongMach.QuanLyPhongMachDataSetTableAdapters.DonThuocTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongMachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDTDataGridViewTextBoxColumn,
            this.tenThuocDataGridViewTextBoxColumn,
            this.ngayCapThuocDataGridViewTextBoxColumn,
            this.tienThuocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.donThuocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // sttDTDataGridViewTextBoxColumn
            // 
            this.sttDTDataGridViewTextBoxColumn.DataPropertyName = "sttDT";
            this.sttDTDataGridViewTextBoxColumn.HeaderText = "sttDT";
            this.sttDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttDTDataGridViewTextBoxColumn.Name = "sttDTDataGridViewTextBoxColumn";
            this.sttDTDataGridViewTextBoxColumn.Width = 68;
            // 
            // tenThuocDataGridViewTextBoxColumn
            // 
            this.tenThuocDataGridViewTextBoxColumn.DataPropertyName = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.HeaderText = "TenThuoc";
            this.tenThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenThuocDataGridViewTextBoxColumn.Name = "tenThuocDataGridViewTextBoxColumn";
            this.tenThuocDataGridViewTextBoxColumn.Width = 98;
            // 
            // ngayCapThuocDataGridViewTextBoxColumn
            // 
            this.ngayCapThuocDataGridViewTextBoxColumn.DataPropertyName = "NgayCapThuoc";
            this.ngayCapThuocDataGridViewTextBoxColumn.HeaderText = "NgayCapThuoc";
            this.ngayCapThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapThuocDataGridViewTextBoxColumn.Name = "ngayCapThuocDataGridViewTextBoxColumn";
            this.ngayCapThuocDataGridViewTextBoxColumn.Width = 132;
            // 
            // tienThuocDataGridViewTextBoxColumn
            // 
            this.tienThuocDataGridViewTextBoxColumn.DataPropertyName = "TienThuoc";
            this.tienThuocDataGridViewTextBoxColumn.HeaderText = "TienThuoc";
            this.tienThuocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienThuocDataGridViewTextBoxColumn.Name = "tienThuocDataGridViewTextBoxColumn";
            this.tienThuocDataGridViewTextBoxColumn.Width = 101;
            // 
            // donThuocBindingSource
            // 
            this.donThuocBindingSource.DataMember = "DonThuoc";
            this.donThuocBindingSource.DataSource = this.quanLyPhongMachDataSet;
            // 
            // quanLyPhongMachDataSet
            // 
            this.quanLyPhongMachDataSet.DataSetName = "QuanLyPhongMachDataSet";
            this.quanLyPhongMachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donThuocTableAdapter
            // 
            this.donThuocTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Nhập tên bệnh nhân";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TraCuuDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TraCuuDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuuDonThuoc";
            this.Load += new System.EventHandler(this.TraCuuDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongMachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyPhongMachDataSet quanLyPhongMachDataSet;
        private System.Windows.Forms.BindingSource donThuocBindingSource;
        private QuanLyPhongMachDataSetTableAdapters.DonThuocTableAdapter donThuocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}