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
    public partial class Fr1QuanLy : Form
    {
        public Fr1QuanLy()
        {
            InitializeComponent();
        }

        private void cHỨNGTỪToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fr2BanHang fr = new Fr2BanHang();
            fr.ShowDialog();
        }//private void cHỨNGTỪToolStripMenuItem_Click(object sender, EventArgs e)

        private void hÓAĐƠNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fr4HoaDon fr = new Fr4HoaDon();
            fr.ShowDialog();
        }//private void hÓAĐƠNToolStripMenuItem1_Click(object sender, EventArgs e)

        private void pHIẾUTHUTIỀNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr5PhieuTT fr = new Fr5PhieuTT();
            fr.ShowDialog();
        }// private void pHIẾUTHUTIỀNToolStripMenuItem_Click(object sender, EventArgs e)

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr6NhanVien fr = new Fr6NhanVien();
            fr.ShowDialog();
        }

        private void kẾTOÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bÚTTOÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Fr7ButToan fr = new Fr7ButToan();
            fr.ShowDialog();
        }

        private void cHỨNGTỪPHIẾUTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrReportPTT fr = new FrReportPTT();
            fr.ShowDialog();
        }
    }
}
