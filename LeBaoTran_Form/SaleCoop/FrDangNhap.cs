using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleCoop
{
    public partial class FrDangNhap : Form
    {
        public FrDangNhap()
        {
            InitializeComponent();
        }
        private void llblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLayMK quenmk = new FrmLayMK();
            quenmk.ShowDialog();
        }
        Function func = new Function();
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản của bạn!");
                return;
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else
            {
                string query = "select * from Account  where UserName = '" + username + "' and passW = '" + password + "'";
                if (func.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fr1QuanLy quanly = new Fr1QuanLy();
                    quanly.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void pbAnMK_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                pbHienMK.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }
        private void pbHienMK_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                pbAnMK.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void pbAnMK_Click_1(object sender, EventArgs e)
        {

        }
    }
}
