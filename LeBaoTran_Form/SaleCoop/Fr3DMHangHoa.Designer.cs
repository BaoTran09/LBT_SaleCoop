namespace SaleCoop
{
    partial class Fr3DMHangHoa
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
            this.dGVHangHoa = new System.Windows.Forms.DataGridView();
            this.maHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMHHCoopDataset = new SaleCoop.DMHHCoopDataset();
            this.gBSearchHH = new System.Windows.Forms.GroupBox();
            this.btnSearchHH = new System.Windows.Forms.Button();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dANHMỤCCHỨNGTỪToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hÓAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIẾUTHUTIỀNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dANHMỤCHÀNGHÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOẠIHÀNGHÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hÀNGHÓAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÀIKHOẢNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHÂNVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kHÁCHHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUAYLẠIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHHH = new System.Windows.Forms.TextBox();
            this.btnSuaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.dMHangHoaTableAdapter = new SaleCoop.DMHHCoopDatasetTableAdapters.DMHangHoaTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBLoaiHH = new System.Windows.Forms.ComboBox();
            this.loaiHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHHCoopDataset = new SaleCoop.LoaiHHCoopDataset();
            this.loaiHHTableAdapter = new SaleCoop.LoaiHHCoopDatasetTableAdapters.LoaiHHTableAdapter();
            this.openFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            this.cmbLoaiSua = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMHHCoopDataset)).BeginInit();
            this.gBSearchHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHHCoopDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // dGVHangHoa
            // 
            this.dGVHangHoa.AutoGenerateColumns = false;
            this.dGVHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHHDataGridViewTextBoxColumn,
            this.tenHHDataGridViewTextBoxColumn,
            this.sLTonDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn});
            this.dGVHangHoa.DataSource = this.dMHangHoaBindingSource;
            this.dGVHangHoa.Location = new System.Drawing.Point(24, 166);
            this.dGVHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dGVHangHoa.Name = "dGVHangHoa";
            this.dGVHangHoa.RowHeadersWidth = 51;
            this.dGVHangHoa.RowTemplate.Height = 24;
            this.dGVHangHoa.Size = new System.Drawing.Size(675, 222);
            this.dGVHangHoa.TabIndex = 2;
            // 
            // maHHDataGridViewTextBoxColumn
            // 
            this.maHHDataGridViewTextBoxColumn.DataPropertyName = "MaHH";
            this.maHHDataGridViewTextBoxColumn.HeaderText = "Mã HH";
            this.maHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHHDataGridViewTextBoxColumn.Name = "maHHDataGridViewTextBoxColumn";
            this.maHHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "Tên HH";
            this.tenHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHHDataGridViewTextBoxColumn.Name = "tenHHDataGridViewTextBoxColumn";
            this.tenHHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sLTonDataGridViewTextBoxColumn
            // 
            this.sLTonDataGridViewTextBoxColumn.DataPropertyName = "SLTon";
            this.sLTonDataGridViewTextBoxColumn.HeaderText = "SL Tồn";
            this.sLTonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLTonDataGridViewTextBoxColumn.Name = "sLTonDataGridViewTextBoxColumn";
            this.sLTonDataGridViewTextBoxColumn.Width = 125;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            this.dVTDataGridViewTextBoxColumn.Width = 125;
            // 
            // dMHangHoaBindingSource
            // 
            this.dMHangHoaBindingSource.DataMember = "DMHangHoa";
            this.dMHangHoaBindingSource.DataSource = this.dMHHCoopDataset;
            // 
            // dMHHCoopDataset
            // 
            this.dMHHCoopDataset.DataSetName = "DMHHCoopDataset";
            this.dMHHCoopDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gBSearchHH
            // 
            this.gBSearchHH.BackColor = System.Drawing.Color.Transparent;
            this.gBSearchHH.Controls.Add(this.btnSearchHH);
            this.gBSearchHH.Controls.Add(this.txtTenHH);
            this.gBSearchHH.Controls.Add(this.label8);
            this.gBSearchHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSearchHH.Location = new System.Drawing.Point(735, 50);
            this.gBSearchHH.Margin = new System.Windows.Forms.Padding(4);
            this.gBSearchHH.Name = "gBSearchHH";
            this.gBSearchHH.Padding = new System.Windows.Forms.Padding(4);
            this.gBSearchHH.Size = new System.Drawing.Size(275, 129);
            this.gBSearchHH.TabIndex = 3;
            this.gBSearchHH.TabStop = false;
            this.gBSearchHH.Text = "TÌM KIẾM ";
            this.gBSearchHH.Enter += new System.EventHandler(this.gBSearchHH_Enter);
            // 
            // btnSearchHH
            // 
            this.btnSearchHH.Location = new System.Drawing.Point(22, 82);
            this.btnSearchHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchHH.Name = "btnSearchHH";
            this.btnSearchHH.Size = new System.Drawing.Size(125, 42);
            this.btnSearchHH.TabIndex = 2;
            this.btnSearchHH.Text = "Tìm kiếm";
            this.btnSearchHH.UseVisualStyleBackColor = true;
            this.btnSearchHH.Click += new System.EventHandler(this.btnSearchHH_Click);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(22, 47);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(247, 27);
            this.txtTenHH.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhập tên hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng hóa";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.Color.Transparent;
            this.picHinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dMHangHoaBindingSource, "HinhAnh", true));
            this.picHinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.dMHangHoaBindingSource, "HinhAnh", true));
            this.picHinhAnh.Location = new System.Drawing.Point(735, 203);
            this.picHinhAnh.Margin = new System.Windows.Forms.Padding(4);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(280, 201);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 4;
            this.picHinhAnh.TabStop = false;
            this.picHinhAnh.Click += new System.EventHandler(this.picHinhAnh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dANHMỤCCHỨNGTỪToolStripMenuItem,
            this.dANHMỤCHÀNGHÓAToolStripMenuItem,
            this.tÀIKHOẢNToolStripMenuItem,
            this.tHOÁTToolStripMenuItem,
            this.qUAYLẠIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1034, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dANHMỤCCHỨNGTỪToolStripMenuItem
            // 
            this.dANHMỤCCHỨNGTỪToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hÓAĐƠNToolStripMenuItem,
            this.pHIẾUTHUTIỀNToolStripMenuItem});
            this.dANHMỤCCHỨNGTỪToolStripMenuItem.Name = "dANHMỤCCHỨNGTỪToolStripMenuItem";
            this.dANHMỤCCHỨNGTỪToolStripMenuItem.Size = new System.Drawing.Size(129, 27);
            this.dANHMỤCCHỨNGTỪToolStripMenuItem.Text = "BÁN HÀNG";
            // 
            // hÓAĐƠNToolStripMenuItem
            // 
            this.hÓAĐƠNToolStripMenuItem.Name = "hÓAĐƠNToolStripMenuItem";
            this.hÓAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.hÓAĐƠNToolStripMenuItem.Text = "HÓA ĐƠN";
            // 
            // pHIẾUTHUTIỀNToolStripMenuItem
            // 
            this.pHIẾUTHUTIỀNToolStripMenuItem.Name = "pHIẾUTHUTIỀNToolStripMenuItem";
            this.pHIẾUTHUTIỀNToolStripMenuItem.Size = new System.Drawing.Size(254, 28);
            this.pHIẾUTHUTIỀNToolStripMenuItem.Text = "PHIẾU THU TIỀN";
            // 
            // dANHMỤCHÀNGHÓAToolStripMenuItem
            // 
            this.dANHMỤCHÀNGHÓAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOẠIHÀNGHÓAToolStripMenuItem});
            this.dANHMỤCHÀNGHÓAToolStripMenuItem.Name = "dANHMỤCHÀNGHÓAToolStripMenuItem";
            this.dANHMỤCHÀNGHÓAToolStripMenuItem.Size = new System.Drawing.Size(246, 27);
            this.dANHMỤCHÀNGHÓAToolStripMenuItem.Text = "DANH MỤC HÀNG HÓA";
            // 
            // lOẠIHÀNGHÓAToolStripMenuItem
            // 
            this.lOẠIHÀNGHÓAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hÀNGHÓAToolStripMenuItem});
            this.lOẠIHÀNGHÓAToolStripMenuItem.Name = "lOẠIHÀNGHÓAToolStripMenuItem";
            this.lOẠIHÀNGHÓAToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.lOẠIHÀNGHÓAToolStripMenuItem.Text = "LOẠI HÀNG HÓA";
            // 
            // hÀNGHÓAToolStripMenuItem
            // 
            this.hÀNGHÓAToolStripMenuItem.Name = "hÀNGHÓAToolStripMenuItem";
            this.hÀNGHÓAToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.hÀNGHÓAToolStripMenuItem.Text = "HÀNG HÓA";
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            this.tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHUToolStripMenuItem,
            this.nHÂNVIÊNToolStripMenuItem,
            this.kHÁCHHÀNGToolStripMenuItem});
            this.tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            this.tÀIKHOẢNToolStripMenuItem.Size = new System.Drawing.Size(141, 27);
            this.tÀIKHOẢNToolStripMenuItem.Text = "ĐỐI TƯỢNG";
            // 
            // tHUToolStripMenuItem
            // 
            this.tHUToolStripMenuItem.Name = "tHUToolStripMenuItem";
            this.tHUToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.tHUToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // nHÂNVIÊNToolStripMenuItem
            // 
            this.nHÂNVIÊNToolStripMenuItem.Name = "nHÂNVIÊNToolStripMenuItem";
            this.nHÂNVIÊNToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.nHÂNVIÊNToolStripMenuItem.Text = "NHÂN VIÊN";
            // 
            // kHÁCHHÀNGToolStripMenuItem
            // 
            this.kHÁCHHÀNGToolStripMenuItem.Name = "kHÁCHHÀNGToolStripMenuItem";
            this.kHÁCHHÀNGToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.kHÁCHHÀNGToolStripMenuItem.Text = "KHÁCH HÀNG";
            // 
            // tHOÁTToolStripMenuItem
            // 
            this.tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            this.tHOÁTToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.tHOÁTToolStripMenuItem.Text = "THOÁT";
            // 
            // qUAYLẠIToolStripMenuItem
            // 
            this.qUAYLẠIToolStripMenuItem.Name = "qUAYLẠIToolStripMenuItem";
            this.qUAYLẠIToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.qUAYLẠIToolStripMenuItem.Text = "QUAY LẠI";
            this.qUAYLẠIToolStripMenuItem.Click += new System.EventHandler(this.qUAYLẠIToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMaCS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSLTon);
            this.groupBox1.Controls.Add(this.txtMaHH);
            this.groupBox1.Controls.Add(this.txtTenHHH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 400);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(675, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SẢN ";
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMHangHoaBindingSource, "MaCS", true));
            this.txtMaCS.Location = new System.Drawing.Point(143, 132);
            this.txtMaCS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(121, 27);
            this.txtMaCS.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã cơ sở";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hàng hóa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(559, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng tồn";
            // 
            // txtDVT
            // 
            this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMHangHoaBindingSource, "DVT", true));
            this.txtDVT.Location = new System.Drawing.Point(586, 128);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(75, 27);
            this.txtDVT.TabIndex = 0;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMHangHoaBindingSource, "DonGia", true));
            this.txtDonGia.Location = new System.Drawing.Point(445, 128);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(106, 27);
            this.txtDonGia.TabIndex = 0;
            // 
            // txtSLTon
            // 
            this.txtSLTon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMHangHoaBindingSource, "SLTon", true));
            this.txtSLTon.Location = new System.Drawing.Point(487, 43);
            this.txtSLTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(120, 27);
            this.txtSLTon.TabIndex = 0;
            // 
            // txtMaHH
            // 
            this.txtMaHH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMHangHoaBindingSource, "MaHH", true));
            this.txtMaHH.Location = new System.Drawing.Point(143, 34);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(121, 27);
            this.txtMaHH.TabIndex = 0;
            // 
            // txtTenHHH
            // 
            this.txtTenHHH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dMHangHoaBindingSource, "TenHH", true));
            this.txtTenHHH.Location = new System.Drawing.Point(143, 81);
            this.txtTenHHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHHH.Name = "txtTenHHH";
            this.txtTenHHH.Size = new System.Drawing.Size(464, 27);
            this.txtTenHHH.TabIndex = 0;
            // 
            // btnSuaHH
            // 
            this.btnSuaHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHH.Location = new System.Drawing.Point(896, 497);
            this.btnSuaHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaHH.Name = "btnSuaHH";
            this.btnSuaHH.Size = new System.Drawing.Size(125, 42);
            this.btnSuaHH.TabIndex = 8;
            this.btnSuaHH.Text = "Sửa";
            this.btnSuaHH.UseVisualStyleBackColor = true;
            this.btnSuaHH.Click += new System.EventHandler(this.btnSuaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHH.Location = new System.Drawing.Point(733, 423);
            this.btnThemHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(125, 42);
            this.btnThemHH.TabIndex = 9;
            this.btnThemHH.Text = "Thêm";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // dMHangHoaTableAdapter
            // 
            this.dMHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chọn loại hàng hóa";
            // 
            // cbBLoaiHH
            // 
            this.cbBLoaiHH.DataSource = this.loaiHHBindingSource;
            this.cbBLoaiHH.DisplayMember = "TenLoai";
            this.cbBLoaiHH.FormattingEnabled = true;
            this.cbBLoaiHH.Location = new System.Drawing.Point(255, 115);
            this.cbBLoaiHH.Margin = new System.Windows.Forms.Padding(4);
            this.cbBLoaiHH.Name = "cbBLoaiHH";
            this.cbBLoaiHH.Size = new System.Drawing.Size(365, 25);
            this.cbBLoaiHH.TabIndex = 10;
            this.cbBLoaiHH.ValueMember = "MaLoaiHH";
            this.cbBLoaiHH.SelectedIndexChanged += new System.EventHandler(this.cbBLoaiHH_SelectedIndexChanged);
            // 
            // loaiHHBindingSource
            // 
            this.loaiHHBindingSource.DataMember = "LoaiHH";
            this.loaiHHBindingSource.DataSource = this.loaiHHCoopDataset;
            // 
            // loaiHHCoopDataset
            // 
            this.loaiHHCoopDataset.DataSetName = "LoaiHHCoopDataset";
            this.loaiHHCoopDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHHTableAdapter
            // 
            this.loaiHHTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialogHinh
            // 
            this.openFileDialogHinh.FileName = "openFileDialog1";
            // 
            // cmbLoaiSua
            // 
            this.cmbLoaiSua.FormattingEnabled = true;
            this.cmbLoaiSua.Location = new System.Drawing.Point(733, 507);
            this.cmbLoaiSua.Name = "cmbLoaiSua";
            this.cmbLoaiSua.Size = new System.Drawing.Size(147, 25);
            this.cmbLoaiSua.TabIndex = 11;
            this.cmbLoaiSua.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSua_SelectedIndexChanged);
            // 
            // Fr3DMHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 586);
            this.Controls.Add(this.cmbLoaiSua);
            this.Controls.Add(this.cbBLoaiHH);
            this.Controls.Add(this.btnSuaHH);
            this.Controls.Add(this.btnThemHH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.gBSearchHH);
            this.Controls.Add(this.dGVHangHoa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fr3DMHangHoa";
            this.Text = "Fr3DMHangHoa";
            this.Load += new System.EventHandler(this.Fr3DMHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMHHCoopDataset)).EndInit();
            this.gBSearchHH.ResumeLayout(false);
            this.gBSearchHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHHCoopDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVHangHoa;
        private System.Windows.Forms.GroupBox gBSearchHH;
        private System.Windows.Forms.Button btnSearchHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dANHMỤCCHỨNGTỪToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hÓAĐƠNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHIẾUTHUTIỀNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dANHMỤCHÀNGHÓAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOẠIHÀNGHÓAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hÀNGHÓAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHÂNVIÊNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kHÁCHHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUAYLẠIToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHHH;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSuaHH;
        private System.Windows.Forms.Button btnThemHH;
        private DMHHCoopDataset dMHHCoopDataset;
        private System.Windows.Forms.BindingSource dMHangHoaBindingSource;
        private DMHHCoopDatasetTableAdapters.DMHangHoaTableAdapter dMHangHoaTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBLoaiHH;
        private LoaiHHCoopDataset loaiHHCoopDataset;
        private System.Windows.Forms.BindingSource loaiHHBindingSource;
        private LoaiHHCoopDatasetTableAdapters.LoaiHHTableAdapter loaiHHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialogHinh;
        private System.Windows.Forms.ComboBox cmbLoaiSua;
    }
}