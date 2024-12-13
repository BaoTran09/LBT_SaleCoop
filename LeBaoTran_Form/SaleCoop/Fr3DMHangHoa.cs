using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaleCoop
{
    public partial class Fr3DMHangHoa : Form
    {
        //KHAI BÁO CÁC THAM SỐ TOÀN CỤC 
        //static string name = "", pass = "";
        string apppath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\MediaCoop\\"; //BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾN THƯ MỤC LƯU APP BÀI LÀM NÀY:

        public Fr3DMHangHoa()
        {
            InitializeComponent();
        }
        private void Fr3DMHangHoa_Load(object sender, EventArgs e)
        {
            this.loaiHHTableAdapter.Fill(this.loaiHHCoopDataset.LoaiHH);
            cbBLoaiHH_SelectedIndexChanged(sender, e);

            // Thêm các tùy chọn tĩnh vào ComboBox
            cmbLoaiSua.Items.Add("Sửa thông tin");
            cmbLoaiSua.Items.Add("Sửa hình ảnh");
            cmbLoaiSua.Items.Add("Sửa cả hai");

            // Đặt giá trị mặc định (nếu cần)
            cmbLoaiSua.SelectedIndex = 0; // Chọn mục đầu tiên làm mặc định


        }

        private void cbBLoaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dMHangHoaTableAdapter.Fill(this.dMHHCoopDataset.DMHangHoa, cbBLoaiHH.SelectedValue.ToString());
            }
            catch (Exception) { }
        }


        private void gBSearchHH_Enter(object sender, EventArgs e)
        {

        }
        //THÊM HÀNG HÓA
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            /*
        //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN NHÂN SỰ / GROUP BOX CHI TIET...
            txtMaHH.Enabled = !txtMaHH.Enabled;
            txtTenHHH.Enabled = !txtTenHHH.Enabled;
            txtMaCS.Enabled = !txtMaCS.Enabled;
            txtSLTon.Enabled = !txtSLTon.Enabled;
            txtDonGia.Enabled = !txtSLTon.Enabled;
            txtDVT.Enabled = !txtDVT.Enabled;

            //khóa các nút lệnh khác (ngoại trừ được Đóng form)
            btnSuaHH.Enabled = !btnSuaHH.Enabled;


            if (btnThemHH.Text == "Thêm")//CHUẨN BỊ THÊM NS
            {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH CHO SP MỚI
                picHinhAnh.ImageLocation = apppath + "ImageChoose.png"; //hiện hình ảnh thông báo NSD chọn hình
                
                picHinhAnh.Click += new EventHandler(picHinhAnh_Click); // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                                                                        //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ơ BÊN PHẢI ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN NS MỚI
                txtMaHH.Text = "";
                txtTenHHH.Text = "";
                txtMaCS.Text = "";
                txtSLTon.Text = "";
                txtDonGia.Text = "";
                txtDVT.Text = "";
                btnThemHH.Text = "Lưu";
                //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin NS mới)
            }
            else //THÊM NS MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW
            {//1. THÊM NS MỚI VÀO DB 
                try
                {//nếu NSD ko chọn hình thì biến toàn cục imagechoose = "" và có nghĩa là NS mới chưa có hình ảnh & ComboBox...ValueMenber = mspb
                    dMHangHoaTableAdapter.Insert(txtMaHH.Text.Trim(), cbBLoaiHH.SelectedValue.ToString(), txtTenHHH.Text, txtMaCS.Text, int.Parse(txtSLTon.Text.Trim()), double.Parse(txtDonGia.Text.Trim()), apppath + imagechoose, txtDVT.Text);
                    MessageBox.Show("THÊM THÔNG TIN HÀNG HÓA THÀNH CÔNG");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI HÀNG HÓA MỚI " + ex.Message); }

                //2. TẢI LẠI DL SAU KHI THÊM NS MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ [COPY code TỪ form_load OR Combobox_selectIndexChanhe]
                cbBLoaiHH_SelectedIndexChanged(sender, e);
                //3. THAY ĐỔI TRANG THÁI THÊM NS MỚI
                //pictureBoxHinh.Click -= pictureBoxHinh_Click;//KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                picHinhAnh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình
                btnThemHH.Text = "Thêm";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới NS khác)
            }*/

            if (btnThemHH.Text == "Thêm") // Chuẩn bị thêm mới
            {
                // Bật các trường nhập liệu
                txtMaHH.Enabled = true;
                txtTenHHH.Enabled = true;
                txtMaCS.Enabled = true;
                txtSLTon.Enabled = true;
                txtDonGia.Enabled = true;
                txtDVT.Enabled = true;

                // Đặt các giá trị rỗng để chuẩn bị thêm mới
                txtMaHH.Text = "";
                txtTenHHH.Text = "";
                txtMaCS.Text = "";
                txtSLTon.Text = "";
                txtDonGia.Text = "";
                txtDVT.Text = "";

                // Hiển thị hình ảnh mặc định
                picHinhAnh.ImageLocation = apppath + "ImageChoose.png";
                picHinhAnh.Click += new EventHandler(picHinhAnh_Click);

                // Đổi trạng thái nút
                btnThemHH.Text = "Lưu";
            }
            else // Lưu thông tin mới
            {
                try
                {
                    // Thêm thông tin hàng hóa mới vào cơ sở dữ liệu
                    dMHangHoaTableAdapter.Insert(
                        txtMaHH.Text.Trim(),
                        cbBLoaiHH.SelectedValue.ToString(),
                        txtTenHHH.Text.Trim(),
                        txtMaCS.Text.Trim(),
                        int.Parse(txtSLTon.Text.Trim()),
                        double.Parse(txtDonGia.Text.Trim()),
                        apppath + imagechoose,
                        txtDVT.Text.Trim()
                    );

                    MessageBox.Show("Thêm thông tin hàng hóa thành công!");

                    // Tải lại dữ liệu sau khi thêm mới
                    cbBLoaiHH_SelectedIndexChanged(sender, e);

                    // Đặt lại trạng thái ban đầu
                    picHinhAnh.ImageLocation = ""; // Xóa hình ảnh chọn
                    btnThemHH.Text = "Thêm";

                    // Khóa lại các trường nhập liệu (nếu cần)
                    txtMaHH.Enabled = false;
                    txtTenHHH.Enabled = false;
                    txtMaCS.Enabled = false;
                    txtSLTon.Enabled = false;
                    txtDonGia.Enabled = false;
                    txtDVT.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi thêm hàng hóa: " + ex.Message);
                }
            }
        }
        static string imagechoose = "";//Biến toàn cục Lưu tên file hình mà NSD đã chọn (Thêm/Sửa) đối với PictureBox

        private void picHinhAnh_Click(object sender, EventArgs e)
        { 
            DialogResult ch = openFileDialogHinh.ShowDialog();//Mở hộp thoại cho phép NSD chọn hình cho nhân sự
            if (ch == DialogResult.OK)//NSD đồng ý với hình đã chọn
            {
                //1. Lưu tên file của hình vừa copy nêu trên vào biến toàn cục để sau này (Thêm/Sửa) sẽ cập nhật vào 2 thuộc tính hinh trong Table DMHH của DB
                imagechoose = System.IO.Path.GetFileName(openFileDialogHinh.FileName);//chỉ lấy tên file ko lấy đường dẫn

                //2. Copy hình vừa chọn vào thư mục hình Media của App (để sau này Copy App đi nơi khác thư mục hình sẽ tự đi theo)
                try
                {
                    System.IO.File.Copy(openFileDialogHinh.FileName, apppath + imagechoose, true);
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sao chép hình vào thư mục của App" + ex.Message); }
            }
        }//private void ChonHinh(object sender, EventArgs e) 
        
        //SỬA HÀNG HÓA
        private void btnSuaHH_Click(object sender, EventArgs e)
        {

            /* //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN NHÂN SỰ / GROUP BOX CHI TIET... 
             //txtMaNS.Enabled = !txtMaNS.Enabled;KHÔNG SỬA PK
             txtMaHH.Enabled = !txtMaHH.Enabled;
             txtTenHHH.Enabled = !txtTenHHH.Enabled;
             txtMaCS.Enabled = !txtMaCS.Enabled;
             txtSLTon.Enabled = !txtSLTon.Enabled;
             txtDonGia.Enabled = !txtSLTon.Enabled;
             txtDVT.Enabled = !txtDVT.Enabled;
             //khóa các nút lệnh khác (ngoại trừ được Đóng form)
             btnThemHH.Enabled = !btnThemHH.Enabled;

             if (btnSuaHH.Text == "Sửa: thông tin hàng hóa")//Bắt đầu sửa
             {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH MỚI CHO SP
                 picHinhAnh.ImageLocation = apppath + "ImageChoose.png"; //hiện hình ảnh thông báo NSD chọn hình
                 picHinhAnh.Click += new EventHandler(picHinhAnh_Click); // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                                                                         //B2: HƯỚNG DẪN CÁCH SỬA
                 MessageBox.Show("Quý vị SỬA trong các ô Text bên phải, CHỌN LẠI HÌNH BẰNG CÁCH CLICK VÀO HÌNH ĐỂ CHỌN HÌNH MỚI THAY THẾ");
                 btnSuaHH.Text = "Lưu (Sửa)";
             }
             else //LƯU SAU KHI SỬA XONG
             {//KIỂM TRA NSD CÓ THAY ĐỔI HÌNH HAY KHÔNG: NẾU CHỌN HÌNH MỚI THÌ THAY; NẾU KHÔNG THÌ GIỮ LẠI HÌNH CŨ
                 if (imagechoose == "") imagechoose = picHinhAnh.ImageLocation;
                 //NSD KHÔNG THAY ĐỔI HÌNH (NÊN giữa lại hình cũ)
                 try
                 { //B3: lưu DB
                     dMHangHoaTableAdapter.Update(txtMaHH.Text.Trim(), txtTenHH.Text, txtMaCS.Text, int.Parse(txtSLTon.Text.Trim()), double.Parse(txtDonGia.Text.Trim()), apppath + imagechoose, txtDVT.Text);
                     MessageBox.Show("Đã sửa xong !");
                 }
                 catch (System.Exception ex) { MessageBox.Show("Có lỗi sửa chữa thông tin sản phẩm " + ex.Message); }
                 //B4: ĐỔI NHÃN 
                 btnSuaHH.Text = "SỬA: Điều chỉnh thông tin HH";
                 // pictureBoxHinh.Click -= pictureBoxHinh_Click;//KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                 picHinhAnh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình

                 //B5: Tải BD lên DataGridView sau khi sửa
                 cbBLoaiHH_SelectedIndexChanged(sender, e);*/
              // Đóng/Mở các trường nhập liệu dựa trên trạng thái ComboBox
                bool suaThongTin = cmbLoaiSua.SelectedItem.ToString() == "Sửa thông tin" || cmbLoaiSua.SelectedItem.ToString() == "Sửa cả hai";
                bool suaHinhAnh = cmbLoaiSua.SelectedItem.ToString() == "Sửa hình ảnh" || cmbLoaiSua.SelectedItem.ToString() == "Sửa cả hai";

                // Bật/Tắt các trường liên quan
                txtMaHH.Enabled = suaThongTin;
                txtTenHHH.Enabled = suaThongTin;
                txtMaCS.Enabled = suaThongTin;
                txtSLTon.Enabled = suaThongTin;
                txtDonGia.Enabled = suaThongTin;
                txtDVT.Enabled = suaThongTin;

                btnThemHH.Enabled = !btnThemHH.Enabled;

                if (btnSuaHH.Text == "Sửa hàng hóa") // Bắt đầu sửa
                {
                    if (suaHinhAnh)
                    {
                        picHinhAnh.ImageLocation = apppath + "ImageChoose.png"; // Hiển thị thông báo chọn hình mới
                        picHinhAnh.Click += new EventHandler(picHinhAnh_Click); // Gán sự kiện Click để chọn hình
                    }

                    if (suaThongTin)
                    {
                        MessageBox.Show("Sửa thông tin trong các ô nhập liệu.");
                    }

                    if (suaHinhAnh && suaThongTin)
                    {
                        MessageBox.Show("Sửa thông tin trong các ô nhập liệu và chọn lại hình ảnh bằng cách click vào hình.");
                    }

                    btnSuaHH.Text = "Lưu sửa";
                }
                else // Lưu sau khi sửa
                {
                    try
                    {
                        if (suaHinhAnh && imagechoose == "")
                        {
                            imagechoose = picHinhAnh.ImageLocation; // Giữ hình cũ nếu không chọn hình mới
                        }

                        // Lưu thông tin sửa vào DB
                        dMHangHoaTableAdapter.Update(
                            txtMaHH.Text.Trim(),
                            suaThongTin ? txtTenHHH.Text : null, // Chỉ cập nhật nếu sửa thông tin
                            suaThongTin ? txtMaCS.Text : null,
                            suaThongTin ? int.Parse(txtSLTon.Text.Trim()) : default(int),
                            suaThongTin ? double.Parse(txtDonGia.Text.Trim()) : default(double),
                            suaHinhAnh ? apppath + imagechoose : null, // Chỉ cập nhật nếu sửa hình ảnh
                            suaThongTin ? txtDVT.Text : null
                        );

                        MessageBox.Show("Đã sửa thành công!");

                        // Reset giao diện
                        btnSuaHH.Text = "Sửa hàng hóa";
                        if (suaHinhAnh)
                        {
                            picHinhAnh.Click -= new EventHandler(picHinhAnh_Click); // Xóa sự kiện Click
                            picHinhAnh.ImageLocation = ""; // Xóa hình thông báo
                        }

                        // Tải lại dữ liệu
                        cbBLoaiHH_SelectedIndexChanged(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi sửa: " + ex.Message);
                    }
                
            }
        }

        private void cmbLoaiSua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchHH_Click(object sender, EventArgs e)
        {
            string tenHH = txtTenHH.Text.Trim();

            // Kiểm tra nếu TextBox để trống
            if (string.IsNullOrEmpty(tenHH))
            {
                MessageBox.Show("Vui lòng nhập tên hàng hóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string query = "SELECT MaHH, MaLoaiHH, TenHH, MaCS, SLTon, DonGia, HinhAnh, DVT FROM DMHangHoa WHERE TenHH LIKE @TenHH";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho câu truy vấn
                        cmd.Parameters.AddWithValue("@TenHH", "%" + tenHH + "%");

                        // Thực thi truy vấn và tải kết quả vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Hiển thị dữ liệu lên DataGridView
                            dGVHangHoa.DataSource = dt;
                        }
                        else
                        {
                            // Thông báo nếu không tìm thấy hàng hóa
                            MessageBox.Show("Không tìm thấy hàng hóa có tên: " + tenHH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



