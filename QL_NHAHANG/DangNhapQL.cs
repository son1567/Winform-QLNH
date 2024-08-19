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
    public partial class DangNhapQL : Form
    {
        ConnectDB db = new ConnectDB();
        public DangNhapQL()
        {
            InitializeComponent();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN JOIN CHUCVU ON NHANVIEN.MACV=CHUCVU.MACV JOIN BOPHAN ON CHUCVU.MABP=BOPHAN.MABP WHERE BOPHAN.MABP='QL' AND MANV ='"+txt_manv.Text+"'";
            DataTable dt = db.getTable(sql);
            if (dt.Rows.Count <= 0)
            {
                lb_thongbao.Text = "Bạn không có quyền truy cập vào chức năng này";
            }
            else
            {
                string mk = dt.Rows[0]["MATKHAU"].ToString().TrimEnd();
                string manv = dt.Rows[0]["MANV"].ToString().Trim();
                if (manv == txt_manv.Text && mk == txt_mk.Text)
                {
                    lb_thongbao.Text = "Đăng nhập thành công";
                    QLNH f = new QLNH(txt_manv.Text, dt.Rows[0]["TENNV"].ToString().Trim());
                    f.Show();
                }
                else
                {
                    lb_thongbao.Text = "Mã nhân viên hoặc mật khẩu không chính xác";
                }
            }
        }

        private void DangNhapQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
