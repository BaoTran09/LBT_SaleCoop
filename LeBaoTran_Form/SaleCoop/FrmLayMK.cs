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
    public partial class FrmLayMK : Form
    {
        public FrmLayMK()
        {
            InitializeComponent();
            lblKQ.Text = "";
        }
        Function func = new Function();
        private void btnLayMK_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Username!");
            }
            else
            {
                string query = "Select * from ACCOUNT where UserName = '" + username + "'";
                if (func.TaiKhoans(query).Count != 0)
                {
                    lblKQ.ForeColor = Color.Blue;
                    lblKQ.Text = "Mật khẩu: " + func.TaiKhoans(query)[0].Password;
                }
                else
                {
                    lblKQ.ForeColor = Color.Red;
                    lblKQ.Text = "Không tồn tại Username này!";

                }
            }
        }
    }
}
