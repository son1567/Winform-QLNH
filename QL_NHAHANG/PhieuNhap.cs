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
    public partial class PhieuNhap : Form
    {
        ConnectDB db = new ConnectDB();
        DataTable dt;
        public PhieuNhap()
        {
            InitializeComponent();
        }
        void load_PhieuNhap()
        {
            string sql = "SELECT * FROM PHIEUNHAP";
            dt = db.getTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MAPN"];
            dt.PrimaryKey = key;
            table_phieunhap.DataSource = dt;
        }
        void load_thang()
        {
            string sql = "SELECT DISTINCT MONTH(NGAYNHAP) AS THANG FROM PHIEUNHAP ORDER BY MONTH(NGAYNHAP)";
            DataTable dt1 = db.getTable(sql);
            cbo_thang.DataSource = dt1;
            cbo_thang.DisplayMember = "THANG";
            cbo_thang.ValueMember = "THANG";
        }
        void load_nam()
        {
            string sql = "SELECT DISTINCT YEAR(NGAYNHAP) AS NAM FROM PHIEUNHAP ORDER BY YEAR(NGAYNHAP) ";
            DataTable dt1 = db.getTable(sql);
            cbo_nam.DataSource = dt1;
            cbo_nam.DisplayMember = "NAM";
            cbo_nam.ValueMember = "NAM";
        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            load_nam();
            load_thang();
            load_PhieuNhap();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM PHIEUNHAP WHERE MONTH(NGAYNHAP) = " + cbo_thang.Text + " AND YEAR(NGAYNHAP) = " + cbo_nam.Text + "";
            dt = db.getTable(sql);
            table_phieunhap.DataSource = dt;
        }

        private void btn_xct_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = table_phieunhap.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            string sql = "SELECT HANGHOA.TENHH, CTPHIEUNHAP.SOLUONG, CTPHIEUNHAP.DONGIA FROM CTPHIEUNHAP, HANGHOA WHERE CTPHIEUNHAP.MAHH=HANGHOA.MAHH AND CTPHIEUNHAP.MAPN = '"+vl+"'";
            DataTable dt1 = db.getTable(sql);
            table_ctpn.DataSource = dt1;
            lb_tt.Text = Math.Round(double.Parse(row.Cells["THANHTIEN"].Value.ToString()),4).ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Rows.Clear();
            table_ctpn.DataSource = dt1;
            lb_tt.Text = "";
            DataGridViewRow row = table_phieunhap.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            string sql = "DELETE CTPHIEUNHAP WHERE MAPN = '" + vl + "'";
            db.getNonquery(sql);
            string sql1 = "DELETE PHIEUNHAP WHERE MAPN = '" + vl + "'";
            db.getNonquery(sql1);
            load_PhieuNhap();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
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
