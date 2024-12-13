using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleCoop
{
    public partial class FrReportPTT : Form
    {
        public FrReportPTT()
        {
            InitializeComponent();
        }
        public class PhieuTTT
        {

        }
        private void FrReportPTT_Load(object sender, EventArgs e)
        {

            this.reportViewerPTT.RefreshReport();
            reportViewerPTT.LocalReport.ReportEmbeddedResource = "SaleCoop.ReportPTT.rdlc";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Hàm tiện ích để lấy dữ liệu từ SQL

        private DataTable GetDataTable(SqlConnection con, string query, string MaPT)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                da.SelectCommand.Parameters.AddWithValue("@MaPT", MaPT);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void btnXuatPT_Click(object sender, EventArgs e)
        {
            string MaPT = txtMaPT.Text.Trim();

            // Truy vấn SQL cho từng DataTable
            string queryPhieuThuTien = @"
                        SELECT PT.MaPT, PT.TGThuTien, PT.PTTT, PT.TriGia, PT.TrangThaiTT, HD.MaHD
                        FROM PhieuThuTien PT
                        JOIN HoaDon HD ON PT.MaHD = HD.MaHD
                        WHERE PT.MaPT = @MaPT";

            string queryCoSo = @"
                        SELECT CS.MaCS, CS.TenCS, CS.DiaChiCS
                        FROM CoSo CS
                        JOIN NhanVien NV ON CS.MaCS = NV.MaCS
                        JOIN HoaDon HD ON NV.MaNV = HD.MaNV
                        JOIN PhieuThuTien PT ON HD.MaHD = PT.MaHD
                        WHERE PT.MaPT = @MaPT";

            string queryNhanVien = @"
                        SELECT NV.MaNV, NV.TenNV
                        FROM NhanVien NV
                        JOIN HoaDon HD ON NV.MaNV = HD.MaNV
                        JOIN PhieuThuTien PT ON HD.MaHD = PT.MaHD
                        WHERE PT.MaPT = @MaPT";

            string queryKhachHang = @"
                        SELECT KH.MaKH, KH.TenKH, KH.DiaChi, KH.SDT_KH
                        FROM KhachHang KH
                        JOIN HoaDon HD ON KH.MaKH = HD.MaKH
                        JOIN PhieuThuTien PT ON HD.MaHD = PT.MaHD
                        WHERE PT.MaPT = @MaPT";

            string queryButToan = @"
                        SELECT BT.MaPT, BT.DienGiai, BT.TKNo, BT.TKCo
                        FROM ButToan BT
                        WHERE BT.MaPT = @MaPT";


            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.QLBH_CoopConnectionString))
            {
                try
                {
                    con.Open();

                    // Lấy dữ liệu từ từng DataTable
             
                    DataTable dtPhieuThuTien = GetDataTable(con, queryPhieuThuTien, MaPT);
                    DataTable dtCoSo = GetDataTable(con, queryCoSo, MaPT);
                    DataTable dtNhanVien = GetDataTable(con, queryNhanVien, MaPT);
                    DataTable dtKhachHang = GetDataTable(con, queryKhachHang, MaPT);
                    DataTable dtButToan = GetDataTable(con, queryButToan, MaPT);

                    // Kiểm tra dữ liệu
                    if (dtPhieuThuTien.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu phù hợp với mã phiếu thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Gán dữ liệu cho các Label từ DataTable
                    DataRow rowPhieuThuTien = dtPhieuThuTien.Rows[0];
                    lbMaHD.Text = rowPhieuThuTien["MaHD"].ToString(); // Mã hóa đơn
                    lbTGThuTien.Text = rowPhieuThuTien["TGThuTien"].ToString(); // Thời gian thu tiền

                    if (dtKhachHang.Rows.Count > 0)
                    {
                        DataRow rowKhachHang = dtKhachHang.Rows[0];
                        lbMaKH.Text = rowKhachHang["MaKH"].ToString(); // Mã khách hàng
                    }

                    if (dtButToan.Rows.Count > 0)
                    {
                        DataRow rowButToan = dtButToan.Rows[0];
                        lbButToan.Text = rowButToan["DienGiai"].ToString(); // Diễn giải bút toán
                    }

                    // Thêm từng DataSource vào ReportViewer
                    reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("PhieuTT", dtPhieuThuTien));
                    reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DataSeCoSo", dtCoSo));
                    reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DataSetNhanVien", dtNhanVien));
                    reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DatasetKhachHang", dtKhachHang));
                    reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DataSetButToan", dtButToan));
                    reportViewerPTT.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reportViewerPTT_Load(object sender, EventArgs e)
        {

        }

        /*
                private void btnXuatPT_Click(object sender, EventArgs e)
                {
                    string MaPT = txtMaPT.Text.Trim();

                    // Truy vấn SQL cho từng DataTable
                    string queryPhieuThuTien = @"
                        SELECT PT.MaPT, PT.TGThuTien, PT.PTTT, PT.TriGia, PT.TrangThaiTT
                        FROM PhieuThuTien PT
                        WHERE PT.MaPT = @MaPT";

                                    string queryCoSo = @"
                        SELECT CS.MaCS, CS.TenCS, CS.DiaChiCS
                        FROM CoSo CS
                        JOIN NhanVien NV ON CS.MaCS = NV.MaCS
                        JOIN HoaDon HD ON NV.MaNV = HD.MaNV
                        JOIN PhieuThuTien PT ON HD.MaHD = PT.MaHD
                        WHERE PT.MaPT = @MaPT";

                                    string queryNhanVien = @"
                        SELECT NV.MaNV, NV.TenNV
                        FROM NhanVien NV
                        JOIN HoaDon HD ON NV.MaNV = HD.MaNV
                        JOIN PhieuThuTien PT ON HD.MaHD = PT.MaHD
                        WHERE PT.MaPT = @MaPT";

                                    string queryKhachHang = @"
                        SELECT KH.MaKH, KH.TenKH, KH.DiaChi, KH.SDT_KH
                        FROM KhachHang KH
                        JOIN HoaDon HD ON KH.MaKH = HD.MaKH
                        JOIN PhieuThuTien PT ON HD.MaHD = PT.MaHD
                        WHERE PT.MaPT = @MaPT";

                                    string queryButToan = @"
                        SELECT BT.MaPT, BT.DienGiai, BT.TKNo, BT.TKCo
                        FROM ButToan BT
                        WHERE BT.MaPT = @MaPT";

                     using (SqlConnection con = new SqlConnection(Properties.Settings.Default.QLBH_CoopConnectionString))
                    {
                        try
                        {
                            con.Open();

                            // Tạo các DataTable
                            DataTable dtPhieuThuTien = GetDataTable(con, queryPhieuThuTien, MaPT);
                            DataTable dtCoSo = GetDataTable(con, queryCoSo, MaPT);
                            DataTable dtNhanVien = GetDataTable(con, queryNhanVien, MaPT);
                            DataTable dtKhachHang = GetDataTable(con, queryKhachHang, MaPT);
                            DataTable dtButToan = GetDataTable(con, queryButToan, MaPT);

                            // Kiểm tra dữ liệu
                            if (dtPhieuThuTien.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy dữ liệu phù hợp với mã phiếu thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Cập nhật thông tin lên ReportViewer
                            reportViewerPTT.LocalReport.DataSources.Clear();

                            // Thêm từng DataSource vào ReportViewer
                            reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("PhieuTT", dtPhieuThuTien));
                            reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DataSeCoSo", dtCoSo));
                            reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DataSetNhanVien", dtNhanVien));
                            reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DatasetKhachHang", dtKhachHang));
                            reportViewerPTT.LocalReport.DataSources.Add(new ReportDataSource("DataSetButToan", dtButToan));

                            // Làm mới báo cáo
                            reportViewerPTT.RefreshReport();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
        */
        /*  private void btnXuatPT_Click(object sender, EventArgs e)
          {
             
          }
        ///////2*/
        ///

        /*  private void btnXuatPT_Click(object sender, EventArgs e)
         {
            string MaPT = txtMaPT.Text.Trim();
             string queryForlbMaHD = "SELECT MaHD  FROM sp_MaDH WHERE MaHD = @MaHD"; // Truy vấn lấy ngày lập phiếu nhập kho
             string queryForlbMaKH = "SELECT MaKH FROM sp_MaKH WHERE MaKH = @MaKH"; // Truy vấn lấy MANCC
             string queryForlbTGThuTien = "SELECT TGThuTien FROM sp_TGThuTien WHERE TGThuTien = @Ngay"; // Truy vấn lấy địa chỉ nhà cung cấp
             string queryForlbButToan = "SELECT DienGiai FROM sp_DienGiai WHERE DienGiai = @DienGiai"; // Truy vấn lấy diễn giải
             string queryForReport = "select kh.TenKH, kh.DiaChi, kh.SDT_KH, cs.TenCS, cs.DiaChiCS,pt.TriGia, pt.PTTT,pt.TrangThaiTT,nv.TenNV,bt.DienGiai,pt.MaPT,hd.MaHD,bt.TKNo,bt.TKCo\r\n FROM sp_ReportPTTT WHERE hd.MaHD=@MaHD"; // Truy vấn lấy dữ liệu cho báo cáo
             // Khởi tạo kết nối cơ sở dữ liệu
             using (SqlConnection con = new SqlConnection(Properties.Settings.Default.QLBH_CoopConnectionString))
             {
                 try
                 {
                     // Mở kết nối
                     con.Open();

                     // **1. Lấy giá trị MaHD và hiển thị trên label3**
                     using (SqlCommand cmd = new SqlCommand(queryForlbMaHD, con))
                     {
                         cmd.Parameters.AddWithValue("@MaPT", MaPT);

                         // Thực thi truy vấn và đọc kết quả
                         using (SqlDataReader reader = cmd.ExecuteReader())
                         {
                             if (reader.Read()) // Nếu có dữ liệu
                             {
                                 string MaHD = reader["MaHD"].ToString();
                                 lbMaKH.Text = MaHD; // Hiển thị trên label3
                             }
                             else
                             {
                                 MessageBox.Show("Không tìm thấy dữ liệu phù hợp với mã phiếu thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 return;
                             }
                         }
                     }

                     // **2. Lấy giá trị địa chỉ nhà cung cấp và hiển thị trên label4**
                     using (SqlCommand cmd = new SqlCommand(queryForlbMaKH, con))
                     {
                         cmd.Parameters.AddWithValue("@MaPT", MaPT);
                         using (SqlDataReader reader = cmd.ExecuteReader())
                         {
                             if (reader.Read()) // Nếu có dữ liệu
                             {
                                 string MaKH = reader["MaKH"].ToString();
                                 lbMaKH.Text = MaKH; // Hiển thị trên label4
                             }
                             else
                             {
                                 lbMaKH.Text = "Không có Mã khách hàng"; // Nếu không tìm thấy, hiển thị thông báo mặc định
                             }
                         }
                     }

                     // **3. Lấy giá trị ngày lập phiếu nhập kho và hiển thị trên label6**
                     // **3. Lấy giá trị ngày lập phiếu nhập kho và hiển thị trên label6**
                     using (SqlCommand cmd = new SqlCommand(queryForlbTGThuTien, con))
                     {
                         cmd.Parameters.AddWithValue("@MaPT", MaPT);
                         using (SqlDataReader reader = cmd.ExecuteReader())
                         {
                             if (reader.Read()) // Nếu có dữ liệu
                             {
                                 // Chuyển đổi giá trị ngày thành kiểu DateTime và định dạng theo yêu cầu
                                 DateTime TGThuTien = Convert.ToDateTime(reader["TGThuTien"]);
                                 lbTGThuTien.Text = TGThuTien.ToString("dd/MM/yyyy"); // Định dạng ngày theo kiểu dd/MM/yyyy
                             }
                             else
                             {
                                 lbTGThuTien.Text = "Không có ngày lập phiếu thu tiền "; // Nếu không tìm thấy, hiển thị thông báo mặc định
                             }
                         }
                     }


                     // **4. Lấy giá trị diễn giải và hiển thị trên label8**
                     using (SqlCommand cmd = new SqlCommand(queryForlbButToan, con))
                     {
                         cmd.Parameters.AddWithValue("@MaPT", MaPT);
                         using (SqlDataReader reader = cmd.ExecuteReader())
                         {
                             if (reader.Read()) // Nếu có dữ liệu
                             {
                                 string DienGiai = reader["DienGiai"].ToString();
                                 lbButToan.Text = DienGiai; // Hiển thị trên label8
                             }
                             else
                             {
                                 lbButToan.Text = "Không có diễn giải"; // Nếu không tìm thấy, hiển thị thông báo mặc định
                             }
                         }
                     }

                     // **5. Lấy dữ liệu cho báo cáo**
                     using (SqlDataAdapter da = new SqlDataAdapter(queryForReport, con))
                     {
                         da.SelectCommand.Parameters.AddWithValue("@MaPT", MaPT);

                         // Tạo DataTable để chứa dữ liệu
                         DataTable dt = new DataTable();
                         da.Fill(dt);

                         // Kiểm tra nếu không có dữ liệu
                         if (dt.Rows.Count == 0)
                         {
                             MessageBox.Show("Không tìm thấy dữ liệu phù hợp với mã phiếu thu tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             return;
                         }

                         // Cập nhật nguồn dữ liệu cho báo cáo
                         ReportDataSource rds = new ReportDataSource("PhieuTT", dt);
                         this.reportViewerPTT.LocalReport.DataSources.Clear();
                         this.reportViewerPTT.LocalReport.DataSources.Add(rds);

                         // Thiết lập tham số cho báo cáo
                         ReportParameter rp1 = new ReportParameter("MaPT", MaPT);
                         ReportParameter rp2 = new ReportParameter("MaHD", lbMaHD.Text); // Truyền giá trị MANCC từ label3
                         ReportParameter rp3 = new ReportParameter("MaKH", lbMaKH.Text); // Truyền giá trị địa chỉ từ label4
                         ReportParameter rp4 = new ReportParameter("TGThuTien", lbTGThuTien.Text); // Truyền giá trị ngày lập từ label6
                         ReportParameter rp5 = new ReportParameter("DienGiai", lbButToan.Text); // Truyền giá trị diễn giải từ label8

                         this.reportViewerPTT.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3, rp4, rp5 });

                         // Làm mới báo cáo
                         this.reportViewerPTT.RefreshReport();
                     }
                 }
                 catch (Exception ex)
                 {
                     // Hiển thị lỗi nếu có
                     MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
         } */




    }

}
   