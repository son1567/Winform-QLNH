using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG
{
    public partial class QLNH : Form
    {
        string mnv;
        string tnv;
        public QLNH()
        {
            InitializeComponent();
        }
        public QLNH(string mnv, string tnv)
        {
            InitializeComponent();
            this.mnv = mnv;
            this.tnv = tnv;
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_NhanVien f = new QL_NhanVien();
            f.Show();
        }

        private void thôngTinMónĂnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QL_MonAn f = new QL_MonAn();
            f.Show();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order f = new Order();
            f.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHang f = new NhapHang();
            f.Show();
        }

        private void QLNH_Load(object sender, EventArgs e)
        {
            lb_mnv.Text = mnv;
            lb_tnv.Text = tnv;
        }

        private void QLNH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoanhThu f = new DoanhThu();
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon f = new HoaDon();
            f.Show();
        }

        private void thôngTinBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_BanAn f = new QL_BanAn();
            f.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhap f = new PhieuNhap();
            f.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            f.Show();
        }

       
    }
}
