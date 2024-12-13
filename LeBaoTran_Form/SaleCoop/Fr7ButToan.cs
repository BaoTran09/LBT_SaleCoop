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

namespace SaleCoop
{
    public partial class Fr7ButToan : Form
    {
        public Fr7ButToan()
        {
            InitializeComponent();
        }

        private void Fr7ButToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'butToanCoopDataSet.ButToan' table. You can move, or remove it, as needed.
            this.butToanTableAdapter.Fill(this.butToanCoopDataSet.ButToan);

        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên form
                string maBT = txtMaBT.Text.Trim();
                string maTKCT = txtMaTKCT.Text.Trim();
                string maPT = txtMaPT.Text.Trim();
                string TKNo = txtTKNo.Text.Trim();
                string TKCo = txtTKCo.Text.Trim();
                DateTime NgayLapBT = dtpNgayLapBT.Value;
                string DienGiai = txtDienGiai.Text.Trim();
                string Tong = txtTong.Text.Trim();
           


                // Kết nối với cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Tạo SqlCommand gọi Stored Procedure
                    SqlCommand cmd = new SqlCommand("sp_ThemBT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@MaBT", maBT);
                    cmd.Parameters.AddWithValue("@MaTKCT", maTKCT);
                    cmd.Parameters.AddWithValue("@MaPT", maPT);
                    cmd.Parameters.AddWithValue("@TKNo", TKNo);
                    cmd.Parameters.AddWithValue("@TKCo", TKCo);
                    cmd.Parameters.Add("@NgayLapBT", SqlDbType.DateTime).Value = NgayLapBT; // Đảm bảo truyền đúng kiểu dữ liệu
                    cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
                    cmd.Parameters.AddWithValue("@Tong", Tong);


                    // Thực thi Stored Procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm bút toán thành công!");
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
                    string query = "SELECT * FROM ButToan";

                    // Dùng SqlDataAdapter để tải dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dgvButToan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }//private void LoadData()
        }

        private void btnSuaBT_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên form
                string maBT = txtMaBT.Text.Trim();
                string maTKCT = txtMaTKCT.Text.Trim();
                string maPT = txtMaPT.Text.Trim();
                string TKNo = txtTKNo.Text.Trim();
                string TKCo = txtTKCo.Text.Trim();
                DateTime NgayLapBT = dtpNgayLapBT.Value;
                string DienGiai = txtDienGiai.Text.Trim();
                string Tong = txtTong.Text.Trim();
                // Kiểm tra điều kiện đầu vào
                if (string.IsNullOrEmpty(maPT))
                {
                    MessageBox.Show("Vui lòng chọn bút toán cần sửa!");
                    return;
                }

                // Kết nối với cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Tạo SqlCommand gọi Stored Procedure
                    SqlCommand cmd = new SqlCommand("sp_SuaBT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@MaBT", maBT);
                    cmd.Parameters.AddWithValue("@MaTKCT", maTKCT);
                    cmd.Parameters.AddWithValue("@MaPT", maPT);
                    cmd.Parameters.AddWithValue("@TKNo", TKNo);
                    cmd.Parameters.AddWithValue("@TKCo", TKCo);
                    cmd.Parameters.Add("@NgayLapBT", SqlDbType.DateTime).Value = NgayLapBT; // Đảm bảo truyền đúng kiểu dữ liệu
                    cmd.Parameters.AddWithValue("@DienGiai", DienGiai);
                    cmd.Parameters.AddWithValue("@Tong", Tong);

                    // Thực thi Stored Procedure
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin bút toán thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bút toán với mã đã chọn.");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult Chon = MessageBox.Show("Bạn có muốn thoát không? (Yes/No)", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Chon == DialogResult.Yes)
            {
                Application.Exit();
                ;
            }
        }
    }
}
