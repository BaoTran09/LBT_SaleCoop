namespace SaleCoop
{
    partial class FrReportPTT
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
            this.reportViewerPTT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbButToan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTGThuTien = new System.Windows.Forms.Label();
            this.btnXuatPT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewerPTT
            // 
            this.reportViewerPTT.LocalReport.ReportEmbeddedResource = "SaleCoop.ReportPTT.rdlc";
            this.reportViewerPTT.Location = new System.Drawing.Point(13, 130);
            this.reportViewerPTT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reportViewerPTT.Name = "reportViewerPTT";
            this.reportViewerPTT.ServerReport.BearerToken = null;
            this.reportViewerPTT.Size = new System.Drawing.Size(1083, 561);
            this.reportViewerPTT.TabIndex = 0;
            this.reportViewerPTT.Load += new System.EventHandler(this.reportViewerPTT_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã PT:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã khách hàng:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập mã hóa đơn:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập nghiệp vụ:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(296, 57);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(47, 17);
            this.lbMaKH.TabIndex = 2;
            this.lbMaKH.Text = "label5";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(274, 11);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(112, 25);
            this.txtMaPT.TabIndex = 3;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(796, 19);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(47, 17);
            this.lbMaHD.TabIndex = 2;
            this.lbMaHD.Text = "label5";
            // 
            // lbButToan
            // 
            this.lbButToan.AutoSize = true;
            this.lbButToan.Location = new System.Drawing.Point(796, 57);
            this.lbButToan.Name = "lbButToan";
            this.lbButToan.Size = new System.Drawing.Size(47, 17);
            this.lbButToan.TabIndex = 2;
            this.lbButToan.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhập ngày thu tiền:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTGThuTien
            // 
            this.lbTGThuTien.AutoSize = true;
            this.lbTGThuTien.Location = new System.Drawing.Point(296, 95);
            this.lbTGThuTien.Name = "lbTGThuTien";
            this.lbTGThuTien.Size = new System.Drawing.Size(47, 17);
            this.lbTGThuTien.TabIndex = 2;
            this.lbTGThuTien.Text = "label5";
            // 
            // btnXuatPT
            // 
            this.btnXuatPT.Location = new System.Drawing.Point(697, 95);
            this.btnXuatPT.Name = "btnXuatPT";
            this.btnXuatPT.Size = new System.Drawing.Size(120, 29);
            this.btnXuatPT.TabIndex = 4;
            this.btnXuatPT.Text = "Xuất phiếu thu";
            this.btnXuatPT.UseVisualStyleBackColor = true;
            this.btnXuatPT.Click += new System.EventHandler(this.btnXuatPT_Click);
            // 
            // FrReportPTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 770);
            this.Controls.Add(this.btnXuatPT);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.lbButToan);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.lbTGThuTien);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewerPTT);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrReportPTT";
            this.Text = "FrReportPTT";
            this.Load += new System.EventHandler(this.FrReportPTT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbButToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTGThuTien;
        private System.Windows.Forms.Button btnXuatPT;
    }
}