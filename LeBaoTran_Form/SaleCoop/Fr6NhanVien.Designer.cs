namespace SaleCoop
{
    partial class Fr6NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.namDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienCoopDataSet = new SaleCoop.NhanVienCoopDataSet();
            this.gBNhanVien = new System.Windows.Forms.GroupBox();
            this.checkBoxNu = new System.Windows.Forms.CheckBox();
            this.CheckBoxNam = new System.Windows.Forms.CheckBox();
            this.txtUS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.nhanVienTableAdapter = new SaleCoop.NhanVienCoopDataSetTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienCoopDataSet)).BeginInit();
            this.gBNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.nuDataGridViewCheckBoxColumn,
            this.namDataGridViewCheckBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.sDTNVDataGridViewTextBoxColumn,
            this.diaChiNVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 315);
            this.dataGridView1.TabIndex = 2;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // nuDataGridViewCheckBoxColumn
            // 
            this.nuDataGridViewCheckBoxColumn.DataPropertyName = "Nu";
            this.nuDataGridViewCheckBoxColumn.HeaderText = "Nữ";
            this.nuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.nuDataGridViewCheckBoxColumn.Name = "nuDataGridViewCheckBoxColumn";
            this.nuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // namDataGridViewCheckBoxColumn
            // 
            this.namDataGridViewCheckBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewCheckBoxColumn.HeaderText = "Nam";
            this.namDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.namDataGridViewCheckBoxColumn.Name = "namDataGridViewCheckBoxColumn";
            this.namDataGridViewCheckBoxColumn.Width = 125;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTNVDataGridViewTextBoxColumn
            // 
            this.sDTNVDataGridViewTextBoxColumn.DataPropertyName = "SDT_NV";
            this.sDTNVDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTNVDataGridViewTextBoxColumn.Name = "sDTNVDataGridViewTextBoxColumn";
            this.sDTNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiNVDataGridViewTextBoxColumn
            // 
            this.diaChiNVDataGridViewTextBoxColumn.DataPropertyName = "DiaChiNV";
            this.diaChiNVDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiNVDataGridViewTextBoxColumn.Name = "diaChiNVDataGridViewTextBoxColumn";
            this.diaChiNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.nhanVienCoopDataSet;
            // 
            // nhanVienCoopDataSet
            // 
            this.nhanVienCoopDataSet.DataSetName = "NhanVienCoopDataSet";
            this.nhanVienCoopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gBNhanVien
            // 
            this.gBNhanVien.Controls.Add(this.checkBoxNu);
            this.gBNhanVien.Controls.Add(this.CheckBoxNam);
            this.gBNhanVien.Controls.Add(this.txtUS);
            this.gBNhanVien.Controls.Add(this.label7);
            this.gBNhanVien.Controls.Add(this.txtChucVu);
            this.gBNhanVien.Controls.Add(this.label6);
            this.gBNhanVien.Controls.Add(this.txtSDT);
            this.gBNhanVien.Controls.Add(this.label5);
            this.gBNhanVien.Controls.Add(this.txtDiaChi);
            this.gBNhanVien.Controls.Add(this.label4);
            this.gBNhanVien.Controls.Add(this.txtTenNV);
            this.gBNhanVien.Controls.Add(this.label3);
            this.gBNhanVien.Controls.Add(this.txtMaCS);
            this.gBNhanVien.Controls.Add(this.label8);
            this.gBNhanVien.Controls.Add(this.txtMaNV);
            this.gBNhanVien.Controls.Add(this.label2);
            this.gBNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNhanVien.Location = new System.Drawing.Point(687, 28);
            this.gBNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.gBNhanVien.Name = "gBNhanVien";
            this.gBNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.gBNhanVien.Size = new System.Drawing.Size(407, 362);
            this.gBNhanVien.TabIndex = 3;
            this.gBNhanVien.TabStop = false;
            this.gBNhanVien.Text = "Thông tin nhân viên";
            // 
            // checkBoxNu
            // 
            this.checkBoxNu.AutoSize = true;
            this.checkBoxNu.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.nhanVienBindingSource, "Nu", true));
            this.checkBoxNu.Location = new System.Drawing.Point(318, 174);
            this.checkBoxNu.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNu.Name = "checkBoxNu";
            this.checkBoxNu.Size = new System.Drawing.Size(57, 23);
            this.checkBoxNu.TabIndex = 2;
            this.checkBoxNu.Text = "Nữ ";
            this.checkBoxNu.UseVisualStyleBackColor = true;
            // 
            // CheckBoxNam
            // 
            this.CheckBoxNam.AutoSize = true;
            this.CheckBoxNam.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.nhanVienBindingSource, "Nam", true));
            this.CheckBoxNam.Location = new System.Drawing.Point(318, 229);
            this.CheckBoxNam.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxNam.Name = "CheckBoxNam";
            this.CheckBoxNam.Size = new System.Drawing.Size(65, 23);
            this.CheckBoxNam.TabIndex = 2;
            this.CheckBoxNam.Text = "Nam";
            this.CheckBoxNam.UseVisualStyleBackColor = true;
            // 
            // txtUS
            // 
            this.txtUS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "UserName", true));
            this.txtUS.Location = new System.Drawing.Point(117, 225);
            this.txtUS.Margin = new System.Windows.Forms.Padding(4);
            this.txtUS.Name = "txtUS";
            this.txtUS.Size = new System.Drawing.Size(170, 27);
            this.txtUS.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "User name";
            // 
            // txtChucVu
            // 
            this.txtChucVu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "ChucVu", true));
            this.txtChucVu.Location = new System.Drawing.Point(161, 124);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(230, 27);
            this.txtChucVu.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "SDT_NV", true));
            this.txtSDT.Location = new System.Drawing.Point(117, 174);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(170, 27);
            this.txtSDT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChiNV", true));
            this.txtDiaChi.Location = new System.Drawing.Point(117, 262);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(274, 27);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT";
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNV", true));
            this.txtTenNV.Location = new System.Drawing.Point(161, 76);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(230, 27);
            this.txtTenNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaCS", true));
            this.txtMaCS.Location = new System.Drawing.Point(117, 314);
            this.txtMaCS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(153, 27);
            this.txtMaCS.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã cơ sở";
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.txtMaNV.Location = new System.Drawing.Point(161, 34);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(153, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(671, 398);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 48);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(973, 398);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(820, 398);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(121, 48);
            this.btnSuaNV.TabIndex = 4;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // Fr6NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 459);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gBNhanVien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fr6NhanVien";
            this.Text = "Fr6NhanVien";
            this.Load += new System.EventHandler(this.Fr6NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienCoopDataSet)).EndInit();
            this.gBNhanVien.ResumeLayout(false);
            this.gBNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBNhanVien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxNu;
        private System.Windows.Forms.CheckBox CheckBoxNam;
        private System.Windows.Forms.TextBox txtUS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuaNV;
        private NhanVienCoopDataSet nhanVienCoopDataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVienCoopDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn namDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiNVDataGridViewTextBoxColumn;
    }
}