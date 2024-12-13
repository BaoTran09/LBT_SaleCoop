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
    public partial class Fr2BanHang : Form
    {
        public Fr2BanHang()
        {
            InitializeComponent();
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr4HoaDon fr = new Fr4HoaDon();
            fr.ShowDialog();

        }// private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)


        private void pHIẾUTHUTIỀNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr5PhieuTT fr = new Fr5PhieuTT();
            fr.ShowDialog();
        }// private void pHIẾUTHUTIỀNToolStripMenuItem_Click(object sender, EventArgs e)

        private void hÀNGHÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr3DMHangHoa fr = new Fr3DMHangHoa();
            fr.ShowDialog();
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
            private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
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
