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
    public partial class HangHoa : Form
    {
        ConnectDB db = new ConnectDB();
        DataTable dt;
        public HangHoa()
        {
            InitializeComponent();
        }
        void Load_HangHoa()
        {
            string sql = "SELECT MAHH, TENHH,MALOAI,MANCC, HSD, SOLUONG FROM HANGHOA";
            dt = db.getTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MAHH"];
            dt.PrimaryKey = key;
            table_hh.DataSource = dt;
        }
        void load_loaiHH()
        {
            string sql = "SELECT * FROM LOAIHH";
            DataTable dt1 = db.getTable(sql);
            cbo_lhh.DataSource = dt1;
            cbo_lhh.DisplayMember = "TENLOAI";
            cbo_lhh.ValueMember = "MALOAI";
        }
        void load_NCC()
        {
            string sql = "SELECT * FROM NCC";
            DataTable dt1 = db.getTable(sql);
            cbo_ncc.DataSource = dt1;
            cbo_ncc.DisplayMember = "TENNCC";
            cbo_ncc.ValueMember = "MANCC";
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            load_loaiHH();
            load_NCC();
            Load_HangHoa();
        }

        private void cbo_lhh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT MAHH, TENHH,MALOAI,MANCC, HSD, SOLUONG FROM HANGHOA WHERE MALOAI = '" + cbo_lhh.SelectedValue + "'";
            dt = db.getTable(sql);
            table_hh.DataSource = dt;
        }

        private void cbo_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT MAHH, TENHH,MALOAI,MANCC, HSD, SOLUONG FROM HANGHOA WHERE MANCC = '" + cbo_ncc.SelectedValue + "'";
            dt = db.getTable(sql);
            table_hh.DataSource = dt;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HangHoa_FormClosing(object sender, FormClosingEventArgs e)
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
