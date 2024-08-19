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
    public partial class NhapHang : Form
    {
        ConnectDB db = new ConnectDB();
        public NhapHang()
        {
            InitializeComponent();
        }

        void load_LoaiHH()
        {
            string sql = "SELECT * FROM LOAIHH";
            DataTable dt1 = db.getTable(sql);
            DataRow dr = dt1.NewRow();
            dr["TENLOAI"] = "Tất cả";
            dr["MALOAI"] = "All";
            dt1.Rows.InsertAt(dr, 0);
            cbo_hh.DataSource = dt1;
            cbo_hh.DisplayMember = "TENLOAI";
            cbo_hh.ValueMember = "MALOAI";
        }
        void load_HH()
        {
            string sql = "SELECT MAHH, TENHH FROM HANGHOA";
            DataTable dt1 = db.getTable(sql);
            table_hh.DataSource = dt1;
        }
        private void NhapHang_Load(object sender, EventArgs e)
        {
            load_LoaiHH();
            load_HH();
        }
        string TaoMaPN()
        {
            string mpn = "PH";
            string sql = "SELECT top 1 * FROM PHIEUNHAP Where MAPN like 'PH%' Order by MAPN desc";
            DataTable dt1 = db.getTable(sql);
            if (dt1.Rows.Count == 0)
            {
                mpn += "001";
            }
            else
            {
                string mpbd = dt1.Rows[0]["MAPN"].ToString();
                string stt = mpbd.Substring(mpbd.Length - 3);
                int so = int.Parse(stt) + 1;
                if (so < 10)
                {
                    mpn += "00" + so;
                }
                else if (so < 100)
                {
                    mpn += "0" + so;
                }
                else
                    mpn += so;
            }
            return mpn;
        }
        private void cbo_hh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT MAHH, TENHH FROM HANGHOA WHERE MALOAI = '"+cbo_hh.SelectedValue+"'";
            if (cbo_hh.SelectedValue.ToString() == "All")
            {
                dt1 = db.getTable("SELECT MAHH, TENHH FROM HANGHOA");
            }
            else
                dt1 = db.getTable(sql);
            table_hh.DataSource = dt1;
        }
        void dongia_tenhh()
        {
            string dg="";
            string tenhh = "";
            DataGridViewSelectedRowCollection selectedRows = table_hh.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                string sql = "SELECT * FROM HANGHOA WHERE MAHH = '"+row.Cells["MAHH"].Value.ToString()+"'";
                DataTable dt = db.getTable(sql);
                dg = dt.Rows[0]["DONGIA"].ToString();
                tenhh = dt.Rows[0]["TENHH"].ToString();
            }
            txt_thh.Text = tenhh;
            txt_dg.Text = Math.Round(double.Parse(dg),4).ToString();
        }
        private void btn_tao_Click(object sender, EventArgs e)
        {
            txt_ngn.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            txt_ma.Text = TaoMaPN();
            txt_tt.Text = "1";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql = "Insert into PHIEUNHAP VALUES ('" + txt_ma.Text + "','" + string.Format("{0:yyyyMMdd}", DateTime.Now) + "','" + cbo_hh.SelectedValue + "',"+txt_tt.Text+")";
            int k = db.getNonquery(sql);
            if (k == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            txt_mactpn.Text = txt_ma.Text;
        }

        private void table_hh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dongia_tenhh();
        }

        private void btn_themhh_Click(object sender, EventArgs e)
        {
            string mahh = "";
            string mapn = "";
            string mancc = "";
            string dvt = "";
            string sl = "";
            string dg = "";
            DataGridViewSelectedRowCollection selectedRows = table_hh.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                string sql = "SELECT * FROM HANGHOA WHERE MAHH = '" + row.Cells["MAHH"].Value.ToString() + "'";
                DataTable dt = db.getTable(sql);
                mahh = row.Cells["MAHH"].Value.ToString();
                mapn = txt_mactpn.Text;
                mancc = dt.Rows[0]["MANCC"].ToString();
                dvt = dt.Rows[0]["DVT"].ToString();
                sl = txt_sl.Text;
                dg = txt_dg.Text;
            }
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(table_phieunhap, mapn, mahh, mancc, dvt,sl,dg);
            table_phieunhap.Rows.Add(r);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = table_phieunhap.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                table_phieunhap.Rows.Remove(row);
            }
        }
        void Reload()
        {
            txt_ma.Clear();
            txt_ngn.Clear();
            txt_tt.Clear();
            table_phieunhap.Rows.Clear();
            txt_mactpn.Clear();
            txt_sl.Clear();
            txt_thh.Clear();
            txt_dg.Clear();
        }
        private void btn_luuctpn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table_phieunhap.Rows.Count - 1; i++)
            {
                DataGridViewRow row = table_phieunhap.Rows[i];
                string sql = "Insert into CTPHIEUNHAP VALUES ('" + row.Cells["MAPN"].Value.ToString() + "','" + row.Cells["MAHH"].Value.ToString()+ "','" + row.Cells["MANCC"].Value.ToString() + "' ,'" + row.Cells["DVT"].Value.ToString() + "'," + row.Cells["SOLUONG"].Value.ToString() + "," + row.Cells["DG"].Value.ToString() + ")";
                db.getNonquery(sql);
                string sql1 = "UPDATE HANGHOA SET SOLUONG = SOLUONG + " + int.Parse(row.Cells["SOLUONG"].Value.ToString()) + " WHERE MAHH='" + row.Cells["MAHH"].Value.ToString().TrimEnd() + "'";
                db.getNonquery(sql1);
            }
            string sql2 = "UPDATE PHIEUNHAP SET THANHTIEN = (SELECT SUM(SOLUONG*DONGIA) FROM CTPHIEUNHAP WHERE PHIEUNHAP.MAPN=CTPHIEUNHAP.MAPN)";
            db.getNonquery(sql2);
            MessageBox.Show("Nhập hàng thành công");
            this.Reload();
        }

        private void NhapHang_FormClosing(object sender, FormClosingEventArgs e)
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
