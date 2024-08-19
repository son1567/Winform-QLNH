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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_dnnv_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void btn_dnql_Click(object sender, EventArgs e)
        {
            DangNhapQL f = new DangNhapQL();
            f.Show();
        }
    }
}
