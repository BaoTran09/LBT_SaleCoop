using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SaleCoop
{
    public partial class Fr4HoaDon : Form
    {
        public Fr4HoaDon()
        {
            InitializeComponent();
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);

        }

        private void Fr4HoaDon_Load(object sender, EventArgs e)
        {
            this.cTHDTableAdapter.Fill(this.cTHDCoopDataSet.CTHD);
            this.hoaDonTableAdapter.Fill(this.hoaDonCoopDataset.HoaDon);
            //       dGVCTHD.CellClick += new DataGridViewCellEventHandler(dGVCTHD_CellClick);
           // dGVHoaDon.CellClick += new DataGridViewCellEventHandler(dGVHoaDon_CellClick);


        }


        string connectionString = "Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"; 

        private void dGVCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
/*
            if (e.RowIndex >= 0)  // Kiểm tra nếu dòng được chọn hợp lệ
            {
                string maHH = dGVCTHD.CurrentRow.Cells["MaHH"].Value.ToString();
               


                // Tạo câu truy vấn để lấy thông tin chi tiết
                string query = " SELECT C.MaHD, C.MaHH, D.TenHH, D.MaLoaiHH, D.DonGia, D.DVT" +
                               "FROM DMHangHoa D " +
                               "INNER JOIN DMHangHoa D ON C.MaHH = D.MaHH " +
                               "WHERE C.MaHD = @MaHD\r\n";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaHH", maHH);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTenHH.Text = reader["TenHH"].ToString();
                    txtMaLoaiHH.Text = reader["TenLoai"].ToString();
                    txtDonGia.Text = reader["DonGia"].ToString();
                    txtDVT.Text = reader["DVT"].ToString();
                }
                reader.Close();  

            }*/
        }
        private void dGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  // Kiểm tra nếu người dùng nhấp vào tiêu đề cột
            if (e.RowIndex < 0) return;

            // Lấy giá trị Mã hóa đơn từ hàng được chọn
            DataGridViewRow selectedRow = dGVHoaDon.Rows[e.RowIndex];
            string MaHD = selectedRow.Cells["MaHD"].Value?.ToString();
            if (!string.IsNullOrEmpty(MaHD))
            {
                // Hiển thị dữ liệu chi tiết hóa đơn vào DataGridView2
                LoadCTHD(MaHD);
            }
        }
        private void LoadCTHD(string MaHD)
        {
            // Chuỗi kết nối của bạn
            string connectionString = "Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True";

            // Câu lệnh SQL để lấy chi tiết hóa đơn
            string query = "SELECT * FROM CTHD WHERE MaHD = @MaHD";

            // Thực hiện truy vấn và tải dữ liệu vào DataGridView2
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", MaHD);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dGVCTHD.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi tiết hóa đơn cho Mã HD: " + MaHD);
                        dGVCTHD.DataSource = null; // Xóa dữ liệu cũ
                    }
                }
            }*/
        }

        /*    private void btnThemHD_Click(object sender, EventArgs e)
            {
                try
                {
                    // Thu thập dữ liệu từ các điều khiển trên form
                    string MaHD = txtMaHD.Text.Trim();
                    string MaNV = txtMaNV.Text.Trim();
                    string MaKH = txtMaKH.Text.Trim();
                    string NgayinHD = dateTimePickerNgayin.Text.Trim();


                    // Kết nối với cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                    {
                        conn.Open();

                        // Tạo SqlCommand gọi Stored Procedure
                        SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho Stored Procedure
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        cmd.Parameters.AddWithValue("@MaNV", MaNV);
                        cmd.Parameters.AddWithValue("@MaKH", MaKH);
                        cmd.Parameters.AddWithValue("@NgayinHD", NgayinHD);

                        // Thực thi Stored Procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm hóa đơn thành công!");
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

                        // Câu truy vấn để lấy dữ liệu từ bảng HoaDon
                        string query = "SELECT * FROM HoaDon";

                        // Dùng SqlDataAdapter để tải dữ liệu vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị dữ liệu lên DataGridView
                        dGVHoaDon.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }//private void LoadData()

            }*/

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên form
                string MaHD = txtMaHD.Text.Trim();
                string MaNV = txtMaNV.Text.Trim();
                string MaKH = txtMaKH.Text.Trim();
                DateTime NgayinHD = dateTimePickerNgayin.Value;  // Lấy giá trị ngày từ DateTimePicker

                // Kết nối với cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Tạo SqlCommand gọi Stored Procedure
                    SqlCommand cmd = new SqlCommand("sp_ThemHoaDon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@MaHD", MaHD);
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);
                    cmd.Parameters.Add("@NgayinHD", SqlDbType.DateTime).Value = NgayinHD; // Đảm bảo truyền đúng kiểu dữ liệu

                    // Thực thi Stored Procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm hóa đơn thành công!");
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

                    // Câu truy vấn để lấy dữ liệu từ bảng HoaDon
                    string query = "SELECT * FROM dbo.HoaDon";

                    // Dùng SqlDataAdapter để tải dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dGVHoaDon.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                // Thu thập dữ liệu từ các điều khiển trên form
                string MaHD = txtMaHD.Text.Trim();
                string MaNV = txtMaNV.Text.Trim();
                string MaKH = txtMaKH.Text.Trim();
                DateTime NgayinHD = dateTimePickerNgayin.Value;


                // Kiểm tra điều kiện đầu vào
                if (string.IsNullOrEmpty(MaHD))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!");
                    return;
                }

                // Kết nối với cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Tạo SqlCommand gọi Stored Procedure
                    SqlCommand cmd = new SqlCommand("sp_SuaHoaDon", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số cho Stored Procedure
                    cmd.Parameters.AddWithValue("@MaHD", MaHD);
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);
                    cmd.Parameters.AddWithValue("@MaKH", MaKH);
                    cmd.Parameters.Add("@NgayinHD", SqlDbType.DateTime).Value = NgayinHD; // Đảm bảo truyền đúng kiểu dữ liệu

                    // Thực thi Stored Procedure
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Sửa thông tin hóa đơn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn với mã đã chọn.");
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

        private void btnSearchHH_Click(object sender, EventArgs e)
        {
            string MaHD = txtSearch_MaHH.Text.Trim();

            // Kiểm tra nếu TextBox để trống
            if (string.IsNullOrEmpty(MaHD))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối cơ sở dữ liệu
            string connectionString = "Data Source=DESKTOP-HCU3M67\\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu truy vấn tìm kiếm theo tên hàng hóa
                    string query = "SELECT * FROM HoaDon WHERE MaHD LIKE @MaHD";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho câu truy vấn
                        cmd.Parameters.AddWithValue("@MaHD", "%" + MaHD + "%");

                        // Thực thi truy vấn và tải kết quả vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Hiển thị dữ liệu lên DataGridView
                            dGVHoaDon.DataSource = dt;
                        }
                        else
                        {
                            // Thông báo nếu không tìm thấy hàng hóa
                            MessageBox.Show("Không tìm thấy hóa đơn có mã: " + MaHD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }

}



    

