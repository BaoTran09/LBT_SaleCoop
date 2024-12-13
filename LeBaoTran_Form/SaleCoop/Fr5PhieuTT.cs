using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleCoop
{
    public partial class Fr5PhieuTT : Form
    {
        public Fr5PhieuTT()
        {
            InitializeComponent();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Fr5PhieuTT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phieuTTCoopDataset.PhieuThuTien' table. You can move, or remove it, as needed.
            this.phieuThuTienTableAdapter.Fill(this.phieuTTCoopDataset.PhieuThuTien);

        }

        private void btnThemPTT_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên form
                string maPT = txtMaPT.Text.Trim();
                string maDH = txtMaHD_PT.Text.Trim();
                DateTime tGThuTien = dtpPTT.Value;
                string pTTT = txtPTTT.Text.Trim();
                string triGia = txtTriGia.Text.Trim();
                string trangThaiTT = txtTrangThaiTT.Text.Trim();


                // Kết nối với cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Tạo SqlCommand gọi Stored Procedure
                    SqlCommand cmd = new SqlCommand("sp_ThemPTT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@MaPT", maPT);
                    cmd.Parameters.AddWithValue("@MaHD", maDH);
                    cmd.Parameters.Add("@TGThuTien", SqlDbType.DateTime).Value = tGThuTien; // Đảm bảo truyền đúng kiểu dữ liệu
                    cmd.Parameters.AddWithValue("@PTTT", pTTT);
                    cmd.Parameters.AddWithValue("@TriGia", triGia);
                    cmd.Parameters.AddWithValue("@TrangThaiTT", trangThaiTT);


                    // Thực thi Stored Procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm phiếu thu thành công!");
                }

                // Làm mới dữ liệu hiển thị sau khi thêm
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Xảy ra Lỗi: {ex.Message}");
            }

        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Câu truy vấn để lấy dữ liệu từ bảng NhanVien
                    string query = "SELECT * FROM PhieuThuTien";

                    // Dùng SqlDataAdapter để tải dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dGVPTT.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }//private void LoadData()
        }

        private void btnSuaPTT_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên form
                string maPT = txtMaPT.Text.Trim();
                string maDH = txtMaHD_PT.Text.Trim();
                DateTime tGThuTien = dtpPTT.Value;
                string pTTT = txtPTTT.Text.Trim();
                string triGia = txtTriGia.Text.Trim();
                string trangThaiTT = txtTrangThaiTT.Text.Trim();


                // Kiểm tra điều kiện đầu vào
                if (string.IsNullOrEmpty(maPT))
                {
                    MessageBox.Show("Vui lòng chọn phiếu thu cần sửa!");
                    return;
                }

                // Kết nối với cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Tạo SqlCommand gọi Stored Procedure
                    SqlCommand cmd = new SqlCommand("sp_SuaPTT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@MaPT", maPT);
                    cmd.Parameters.AddWithValue("@MaHD", maDH);
                    cmd.Parameters.Add("@TGThuTien", SqlDbType.DateTime).Value = tGThuTien; // Đảm bảo truyền đúng kiểu dữ liệu
                    cmd.Parameters.AddWithValue("@PTTT", pTTT);
                    cmd.Parameters.AddWithValue("@TriGia", triGia);
                    cmd.Parameters.AddWithValue("@TrangThaiTT", trangThaiTT);

                    // Thực thi Stored Procedure
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin phiếu thu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phiếu thu với mã đã chọn.");
                    }
                }//private void btnSuaNV_Click(object sender, EventArgs e)

                // Làm mới dữ liệu hiển thị
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }//LoadData(); sửa
        }

        private void qUAYLẠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn đóng màn hình không? (Yes/No)", "Xác nhận đóng",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();


            }
        }
    }
}
