using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace QL_NHAHANG
{
    public partial class DoanhThu : Form
    {
        ConnectDB db = new ConnectDB();
        public DoanhThu()
        {
            InitializeComponent();
        }
        void load_cboThang()
        {
            string sql = "SELECT DISTINCT MONTH(NGAYHD) AS THANG FROM HOADON ORDER BY MONTH(NGAYHD) ";
            DataTable dt1 = db.getTable(sql);
            cbo_thang.DataSource = dt1;
            cbo_thang.DisplayMember = "THANG";
            cbo_thang.ValueMember = "THANG";
        }
        void load_cboNam()
        {
            string sql = "SELECT DISTINCT YEAR(NGAYHD) AS NAM FROM HOADON ORDER BY YEAR(NGAYHD) ";
            DataTable dt1 = db.getTable(sql);
            cbo_nam.DataSource = dt1;
            cbo_nam.DisplayMember = "NAM";
            cbo_nam.ValueMember = "NAM";
            cbo_nam1.DataSource = dt1;
            cbo_nam1.DisplayMember = "NAM";
            cbo_nam1.ValueMember = "NAM";
        }
        void loadDoanhThuNgay()
        {
            string sql = "SELECT NGAYHD, SUM(TONGTIEN) AS TONGTIEN FROM HOADON WHERE YEAR(NGAYHD) = " + cbo_nam1.SelectedValue + " AND MONTH(NGAYHD) = " + cbo_thang.SelectedValue + " GROUP BY NGAYHD ORDER BY NGAYHD";
            DataTable dt = db.getTable(sql);
            var dailyData = new Series("Doanh thu theo ngày");
            dailyData.ChartType = SeriesChartType.Column;
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = (DateTime)row["NGAYHD"];
                double revenue = Convert.ToDouble(row["TONGTIEN"]);
                // Thêm dữ liệu vào bộ dữ liệu của biểu đồ theo ngày
                dailyData.Points.AddXY(date.ToString("dd/MM/yyyy"), revenue);
            }
            DTN.Series.Clear();
            DTN.Series.Add(dailyData);
            DTN.ChartAreas[0].AxisX.Interval = 1;
            DTN.ChartAreas[0].AxisX.IsLabelAutoFit = false;
        }
        void loadDoanhThuThang()
        {
            string sql = "SELECT MONTH(NGAYHD) AS THANG, SUM(TONGTIEN) AS TONGTIEN FROM HOADON WHERE YEAR(NGAYHD) = "+cbo_nam.SelectedValue+" GROUP BY MONTH(NGAYHD)";
            DataTable dt = db.getTable(sql);
            var monthlyData = new Series("Doanh thu theo tháng");
            monthlyData.ChartType = SeriesChartType.Line;
            monthlyData.BorderWidth = 3;
            monthlyData.Color = Color.Blue;
            foreach (DataRow row in dt.Rows)
            {
                int thang = int.Parse(row["THANG"].ToString());
                double revenue = Convert.ToDouble(row["TONGTIEN"]);

                // Thêm dữ liệu vào bộ dữ liệu của biểu đồ theo tháng
                monthlyData.Points.AddXY(thang, revenue);
            }
            DTT.Series.Clear();
            DTT.Series.Add(monthlyData);
            DTT.ChartAreas[0].AxisX.Interval = 1;
            DTT.ChartAreas[0].AxisX.IsLabelAutoFit = false;
        }
        void load_cboloaiMonAn()
        {
            string sql = "SELECT * FROM LOAISP";
            DataTable dt1 = db.getTable(sql);
            cbo_loaimonan.DataSource = dt1;
            cbo_loaimonan.DisplayMember = "TENLOAI";
            cbo_loaimonan.ValueMember = "MALOAI";
        }
        void loadslmonan()
        {
            string sql = "SELECT TOP 5 THUCDON.TENSP, SUM(CHITIETHD.SOLUONG) AS TONGSOLUONG FROM CHITIETHD JOIN THUCDON ON CHITIETHD.MASP = THUCDON.MASP  WHERE THUCDON.MALOAI = '"+cbo_loaimonan.SelectedValue+"' GROUP BY THUCDON.TENSP ORDER BY TONGSOLUONG DESC ";
            DataTable dt = db.getTable(sql);
            var Soluongbanra = new Series("Top các các sản phẩm có số lượng bán ra cao nhất");
            Soluongbanra.ChartType = SeriesChartType.Column;
            for (int i=0;i<=dt.Rows.Count-1;i++)
            {
                string tenSP = dt.Rows[i]["TENSP"].ToString();
                int tongSoLuong = int.Parse(dt.Rows[i]["TONGSOLUONG"].ToString());
                Soluongbanra.Points.AddXY(tenSP, tongSoLuong);
            }
            chart_slsp.Series.Clear();
            chart_slsp.Series.Add(Soluongbanra);
        }
        void loadLoaiMonAn()
        {
            string sql = "SELECT LOAISP.TENLOAI, SUM (TONGTIEN) AS TONGTIEN FROM HOADON JOIN CHITIETHD ON HOADON.MAHD=CHITIETHD.MAHD JOIN THUCDON ON THUCDON.MASP = CHITIETHD.MASP JOIN LOAISP ON LOAISP.MALOAI = THUCDON.MALOAI GROUP BY LOAISP.TENLOAI";
            var LoaiMonAn = new Series("Doanh thu của các loại món ăn");
            LoaiMonAn.ChartType = SeriesChartType.Pie;
            DataTable dt = db.getTable(sql);
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                string TenLoai = dt.Rows[i]["TENLOAI"].ToString();
                decimal tongtien = decimal.Parse(dt.Rows[i]["TONGTIEN"].ToString());
                LoaiMonAn.Points.AddXY(TenLoai, tongtien);
            }
            chart_lsp.Series.Clear();
            chart_lsp.Size = new Size(400, 400);
            chart_lsp.Series.Add(LoaiMonAn);
        }
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            load_cboNam();
            load_cboThang();
            loadDoanhThuNgay();
            loadDoanhThuThang();
            loadslmonan();
            load_cboloaiMonAn();
            loadLoaiMonAn();
        }

        private void DoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            loadslmonan();
        }

        private void btn_timthang_Click(object sender, EventArgs e)
        {
            loadDoanhThuNgay();
        }

        private void btn_timnam_Click(object sender, EventArgs e)
        {
            loadDoanhThuThang();
        }
    }
}
