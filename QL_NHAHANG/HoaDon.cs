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
    public partial class HoaDon : Form
    {
        ConnectDB db = new ConnectDB();
        DataTable dt;
        public HoaDon()
        {
            InitializeComponent();
        }
        void load_HoaDon()
        {
            string sql = "SELECT * FROM HOADON";
            dt = db.getTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MAHD"];
            dt.PrimaryKey = key;
            table_hoadon.DataSource = dt;
        }
        void load_thang()
        {
            string sql = "SELECT DISTINCT MONTH(NGAYHD) AS THANG FROM HOADON ORDER BY MONTH(NGAYHD) ";
            DataTable dt1 = db.getTable(sql);
            cbo_thang.DataSource = dt1;
            cbo_thang.DisplayMember = "THANG";
            cbo_thang.ValueMember = "THANG";
        }
        void load_nam()
        {
            string sql = "SELECT DISTINCT YEAR(NGAYHD) AS NAM FROM HOADON ORDER BY YEAR(NGAYHD) ";
            DataTable dt1 = db.getTable(sql);
            cbo_nam.DataSource = dt1;
            cbo_nam.DisplayMember = "NAM";
            cbo_nam.ValueMember = "NAM";
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            load_nam();
            load_thang();
            load_HoaDon();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM HOADON WHERE MONTH(NGAYHD) = " + cbo_thang.Text + " AND YEAR(NGAYHD) = " + cbo_nam.Text + "";
            dt = db.getTable(sql);
            table_hoadon.DataSource = dt;
        }

        private void btn_xct_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = table_hoadon.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            string sql = "SELECT THUCDON.TENSP, SOLUONG, CHITIETHD.DONGIA FROM CHITIETHD, THUCDON WHERE CHITIETHD.MASP=THUCDON.MASP AND CHITIETHD.MAHD = '" + vl + "'";
            DataTable dt1 = db.getTable(sql);
            table_cthd.DataSource = dt1;
            lb_tt.Text = (Math.Round(double.Parse(row.Cells["TONGTIEN"].Value.ToString()),4)).ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Rows.Clear();
            table_cthd.DataSource = dt1;
            lb_tt.Text = "";
            DataGridViewRow row = table_hoadon.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            string sql = "DELETE CHITIETHD WHERE MAHD = '" + vl + "'";
            db.getNonquery(sql);
            string sql1 = "DELETE HOADON WHERE MAHD = '" + vl + "'";
            db.getNonquery(sql1);
            load_HoaDon();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
