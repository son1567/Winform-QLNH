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
    public partial class DangNhap : Form
    {
        ConnectDB db = new ConnectDB();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE MANV = '" + txt_manv.Text + "'";
            DataTable dt = db.getTable(sql);
            if (dt.Rows.Count <= 0)
            {
                lb_tb.Text = "Mã nhân viên không đúng";
            }
            else
            {
                string mk = dt.Rows[0]["MATKHAU"].ToString().TrimEnd();
                string manv = dt.Rows[0]["MANV"].ToString().Trim();
                if (manv == txt_manv.Text && mk == txt_mk.Text)
                {
                    Order o = new Order(txt_manv.Text, dt.Rows[0]["TENNV"].ToString());
                    o.Show();
                }
                else
                {
                    lb_tb.Text = "Mật khẩu không đúng";
                }
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
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
