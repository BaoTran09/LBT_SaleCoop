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
    public partial class Fr6NhanVien : Form
    {
        public Fr6NhanVien()
        {
            InitializeComponent();
        }

        private void Fr6NhanVien_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.nhanVienCoopDataSet.NhanVien);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             try
                {
                    // Thu thập dữ liệu từ các điều khiển trên form
                    string maNV = txtMaNV.Text.Trim();
                    string tenNV = txtTenNV.Text.Trim();
                    bool nu = checkBoxNu.Checked; // RadioButton chọn giới tính Nữ
                    bool nam = checkBoxNu.Checked; // RadioButton chọn giới tính Nam
                    string sdt = txtSDT.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string chucVu = txtChucVu.Text.Trim();
                    string maCS = txtMaCS.Text.Trim();
                    string userName = txtUS.Text.Trim();

                    // Kết nối với cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                    {
                        conn.Open();

                        // Tạo SqlCommand gọi Stored Procedure
                        SqlCommand cmd = new SqlCommand("ThemNhanVien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho Stored Procedure
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@Nu", nu);
                        cmd.Parameters.AddWithValue("@Nam", nam);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                        cmd.Parameters.AddWithValue("@MaCS", maCS);
                        cmd.Parameters.AddWithValue("@UserName", userName);

                        // Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm nhân viên thành công!");
                    }

                    // Làm mới dữ liệu hiển thị sau khi thêm
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Xảy ra Lỗi: {ex.Message}");
                }
        }//private void btnThem_Click(object sender, EventArgs e)

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Câu truy vấn để lấy dữ liệu từ bảng NhanVien
                    string query = "SELECT * FROM NhanVien";

                    // Dùng SqlDataAdapter để tải dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }//private void LoadData()

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
                try
                {
                    // Thu thập dữ liệu từ các điều khiển trên form
                    string maNV = txtMaNV.Text.Trim(); // Mã nhân viên không được thay đổi
                    string tenNV = txtTenNV.Text.Trim();
                    bool nu = checkBoxNu.Checked; // RadioButton cho giới tính Nữ
                    bool nam = CheckBoxNam.Checked; // RadioButton cho giới tính Nam
                    string sdt = txtSDT.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string chucVu = txtChucVu.Text.Trim();
                    string maCS = txtMaCS.Text.Trim();
                    string userName = txtUS.Text.Trim();

                    // Kiểm tra điều kiện đầu vào
                    if (string.IsNullOrEmpty(maNV))
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                        return;
                    }

                    // Kết nối với cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                    {
                        conn.Open();

                        // Tạo SqlCommand gọi Stored Procedure
                        SqlCommand cmd = new SqlCommand("SuaNhanVien", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho Stored Procedure
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@Nu", nu);
                        cmd.Parameters.AddWithValue("@Nam", nam);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                        cmd.Parameters.AddWithValue("@MaCS", maCS);
                        cmd.Parameters.AddWithValue("@UserName", userName);

                        // Thực thi Stored Procedure
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Sửa thông tin nhân viên thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên với mã đã chọn.");
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
