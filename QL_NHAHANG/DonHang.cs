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
    public partial class DonHang : Form
    {
        ConnectDB db = new ConnectDB();
        string maban;
        double thanhtien;
        string manv;
        string tennv;
        DataGridView tb_cthd = new DataGridView();
        public DonHang()
        {
            InitializeComponent();
        }
        public DonHang(string maban, double thanhtien, string manv, string tennv)
        {
            InitializeComponent();
            this.maban = maban;
            this.thanhtien = thanhtien;
            this.manv = manv;
            this.tennv = tennv;
        }
        void load_BA()
        {
            string sql = "SELECT * FROM DONHANG";
            DataTable dt1 = db.getTable(sql);
            cbo_ba.DataSource = dt1;
            cbo_ba.DisplayMember = "MABAN";
            cbo_ba.ValueMember = "MABAN";
        }
        string TaoMaKH()
        {
            string mkh = "KH";
            string sql = "SELECT top 1 * FROM KHACHHANG Where MAKH like 'KH%' Order by MAKH desc";
            DataTable dt1 = db.getTable(sql);
            if (dt1.Rows.Count == 0)
            {
                mkh += "001";
            }
            else
            {
                string mkbd = dt1.Rows[0]["MAKH"].ToString();
                string stt = mkbd.Substring(mkbd.Length - 3);
                int so = int.Parse(stt) + 1;
                if (so < 10)
                {
                    mkh += "00" + so;
                }
                else if (so < 100)
                {
                    mkh += "0" + so;
                }
                else
                    mkh += so;
            }
            return mkh;
        }
        string TaoMaHD()
        {
            string mhd = "HD";
            string sql = "SELECT top 1 * FROM HOADON Where MAHD like 'HD%' Order by MAHD desc";
            DataTable dt1 = db.getTable(sql);
            if (dt1.Rows.Count == 0)
            {
                mhd += "001";
            }
            else
            {
                string mhdbd = dt1.Rows[0]["MAHD"].ToString();
                string stt = mhdbd.Substring(mhdbd.Length - 3);
                int so = int.Parse(stt) + 1;
                if (so < 10)
                {
                    mhd += "00" + so;
                }
                else if (so < 100)
                {
                    mhd += "0" + so;
                }
                else
                    mhd += so;
            }
            return mhd;
        }
        private void btn_taoKH_Click(object sender, EventArgs e)
        {
            txt_maKH.Text = TaoMaKH();
            txt_tenKH.Text = "";
            txt_sđtKH.Text = "";
            txt_dc.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG VALUES ('" + txt_maKH.Text + "',N'" + txt_tenKH.Text + "',N'" + txt_dc.Text + "','" + txt_sđtKH.Text + "')";
            int k = db.getNonquery(sql);
            if (k == 1)
            {
                txt_hdkh.Text = txt_maKH.Text;
                MessageBox.Show("Thêm thành công");
                txt_maKH.Text = "";
                txt_tenKH.Text = "";
                txt_sđtKH.Text = "";
                txt_dc.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            load_BA();
            lb_tkh.Text = "";
            lb_mkh.Text = "";
            lb_mdh.Text = "";
            lb_ba.Text = "";
            lb_tongtien.Text = "";
            lb_mnv.Text = manv;
            lb_tnv.Text = tennv;
            txt_nv.Text = manv;
            lb_tg.Text = string.Format("{0:dd/MM/yyy}", DateTime.Now);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT MAKH, TENKH FROM KHACHHANG WHERE DTHOAI = '" + txt_sdt.Text + "'";
            dt1 = db.getTable(sql);
            if (dt1.Rows.Count == 0)
            {
                lb_mkh.Text = "Số điện thoại không tồn tại";
            }
            else
            {
                lb_mkh.Text = dt1.Rows[0]["MAKH"].ToString();
                lb_tkh.Text = dt1.Rows[0]["TENKH"].ToString();
                txt_hdkh.Text = lb_mkh.Text;
            }
        }

        
        private void btn_tt_Click(object sender, EventArgs e)
        {
            List<RadioButton> ds = gr_hd.Controls.OfType<RadioButton>().ToList();
            string httt = "";
            foreach (RadioButton rd in ds)
            {
                if (rd.Checked)
                    httt = rd.Text;
            }
            string mhd = TaoMaHD();
            string sql = "INSERT INTO HOADON VALUES ('" + mhd + "','" + txt_nv.Text + "','" + txt_hdkh.Text + "','" + lb_ba.Text + "','" + string.Format("{0:yyyyMMdd}", DateTime.Now) + "',N'" + httt + "'," + lb_tongtien.Text + ")";
            db.getNonquery(sql);
            string mdh = "";
            DataTable dt1;
            mdh = lb_mdh.Text;
            string sql1 = "SELECT * FROM CTDONHANG WHERE MADH = '" + mdh + "'";
            dt1 = db.getTable(sql1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string sql2 = "Insert into CHITIETHD values ('" + mhd + "','" + dt1.Rows[i]["MASP"].ToString() + "'," + dt1.Rows[i]["SOLUONG"].ToString() + "," + dt1.Rows[i]["DONGIA"].ToString() + ")";
                db.getNonquery(sql2);
            }
            MessageBox.Show("Thanh toán thành công");
            string sql3 = "DELETE FROM CTDONHANG WHERE MADH = '" + mdh + "'";
            db.getNonquery(sql3);
            string sql4 = "DELETE FROM DONHANG WHERE MADH='" + mdh + "'";
            db.getNonquery(sql4);
            load_BA();
            lb_mdh.Text = "";
            lb_ba.Text = "";
            lb_tongtien.Text = "";
            txt_hdkh.Text = "";
            txt_sdt.Text = "";
            lb_mkh.Text = "";
            lb_tkh.Text = "";
        }

        private void btn_timdh_Click(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM DONHANG WHERE MABAN = '" + cbo_ba.SelectedValue + "'";
            dt1 = db.getTable(sql);
            lb_mdh.Text = dt1.Rows[0]["MADH"].ToString();
            lb_ba.Text = dt1.Rows[0]["MABAN"].ToString();
            if (DateTime.Now.Month == 12 && lb_tkh.Text != "")
            {
                lb_tongtien.Text = (double.Parse(dt1.Rows[0]["TONGTIEN"].ToString()) - (double.Parse(dt1.Rows[0]["TONGTIEN"].ToString())*0.1)).ToString();
            }
            else
            {
                lb_tongtien.Text = Math.Round(double.Parse(dt1.Rows[0]["TONGTIEN"].ToString()),4).ToString();
            }
        }

        private void DonHang_FormClosing(object sender, FormClosingEventArgs e)
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
