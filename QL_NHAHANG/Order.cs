using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QL_NHAHANG
{
    public partial class Order : Form
    {
        string manv;
        string tennv;
        public Order()
        {
            InitializeComponent();
        }
        public Order(string manv,string tennv)
        {
            InitializeComponent();
            this.manv = manv;
            this.tennv = tennv;
        }
        public void reload()
        {
            load_banan();
            load_cboDH();
            table_order.Rows.Clear();
            lb_ba.Text = "";
            lb_tt.Text = "";
        }
        ConnectDB db = new ConnectDB();
        DataTable dt;
        void load_banan()
        {
            SqlConnection connection = new SqlConnection(db.ck);
            connection.Open();
            string sql = "SELECT MABAN FROM BANAN";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Button> ds = dsba.Controls.OfType<Button>().ToList();
            int i = 0;
            while (reader.Read() && i < ds.Count)
            {
                Button btn = ds[i];
                btn.Text = reader.GetValue(0).ToString();
                btn.BackColor = Color.White;
                i++;
            }
            string sql1 = "select DONHANG.MABAN from DONHANG, BANAN where BANAN.MABAN = DONHANG.MABAN";
            DataTable dt1 = db.getTable(sql1);
            for (int h = 0; h < dt1.Rows.Count; h++)
            {
                foreach (Button btn in ds)
                {
                    if (btn.Text.CompareTo(dt1.Rows[h]["MABAN"].ToString()) == 0)
                    {
                        btn.BackColor = Color.Red;
                    }
                }
            }
                connection.Close();
        }
        void load_DMMA()
        {
            string sql = "SELECT * FROM LOAISP";
            DataTable dt1 = db.getTable(sql);
            DataRow dr = dt1.NewRow();
            dr["MALOAI"] = "All";
            dr["TENLOAI"] = "Tất cả";
            dt1.Rows.InsertAt(dr, 0);
            cbo_dmma.DataSource = dt1;
            cbo_dmma.DisplayMember = "TENLOAI";
            cbo_dmma.ValueMember = "MALOAI";
        }
        void load_MonAn()
        {
            string sql = "SELECT MASP, TENSP,DVT,DONGIA FROM THUCDON";
            dt = db.getTable(sql);
            table_monan.DataSource = dt;
        }
        void load_cboDH()
        {
            string sql = "SELECT * FROM DONHANG";
            DataTable dt1 = db.getTable(sql);
            cbo_dh.DataSource = dt1;
            cbo_dh.DisplayMember = "MADH";
            cbo_dh.ValueMember = "MADH";
        }
        void DataBinding(DataTable dt)
        {
            txt_ten.DataBindings.Clear();
            txt_dvt.DataBindings.Clear();
            txt_dg.DataBindings.Clear();
            txt_mma.DataBindings.Clear();
            txt_ten.DataBindings.Add("Text", dt, "TENSP");
            txt_dvt.DataBindings.Add("Text", dt, "DVT");
            txt_dg.DataBindings.Add("Text", dt, "DONGIA");
            txt_mma.DataBindings.Add("Text", dt, "MASP");
        }
        private void ChonBan_Load(object sender, EventArgs e)
        {
            load_DMMA();
            load_banan();
            load_MonAn();
            load_cboDH();
            DataBinding(dt);
            lb_mnv.Text = manv;
            lb_tnv.Text = tennv;
            lb_tg.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
        }

        private void btn_chonmon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(table_order, txt_mma.Text,txt_ten.Text, txt_sl.Text, txt_dg.Text);
            table_order.Rows.Add(row);
            double thanhtien = double.Parse(lb_tt.Text) + double.Parse(txt_dg.Text) * double.Parse(txt_sl.Text);
            lb_tt.Text = Math.Round(thanhtien,4).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if (ctr.BackColor == Color.White)
            {
                ctr.BackColor = Color.Blue;
                lb_ba.Text = ctr.Text;
            }
            else if (ctr.BackColor == Color.Blue)
            {
                ctr.BackColor = Color.White;
                lb_ba.Text = "";
            }
            else
            {
                MessageBox.Show("Bàn này đang được sử dụng");
            }
        }

        private void cbo_dmma_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM THUCDON WHERE MALOAI = '" + cbo_dmma.SelectedValue + "'";
            if (cbo_dmma.SelectedValue.ToString() == "All")
            {
                dt1 = db.getTable("SELECT * FROM THUCDON");
            }
            else
                dt1 = db.getTable(sql);
            table_monan.DataSource = dt1;
            DataBinding(dt1);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = table_order.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                double thanhtien = double.Parse(lb_tt.Text)-int.Parse(row.Cells["SOLUONG"].Value.ToString()) * double.Parse(row.Cells["DONGIA"].Value.ToString());
                lb_tt.Text = thanhtien.ToString();
                table_order.Rows.Remove(row);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            double thanhtien = 0;
            for (int i = 0; i <= table_order.Rows.Count - 2; i++)
            {
                DataGridViewRow row = table_order.Rows[i];
                thanhtien += int.Parse(row.Cells["SOLUONG"].Value.ToString()) * double.Parse(row.Cells["DONGIA"].Value.ToString());
            }
                
                lb_tt.Text = thanhtien.ToString();
        }

        string TaoMaDH()
        {
            string mdh = "DH";
            string sql = "SELECT top 1 * FROM DONHANG Where MADH like 'DH%' Order by MADH desc";
            DataTable dt1 = db.getTable(sql);
            if (dt1.Rows.Count == 0)
            {
                mdh += "001";
            }
            else
            {
                string mhdbd = dt1.Rows[0]["MADH"].ToString();
                string stt = mhdbd.Substring(mhdbd.Length - 3);
                int so = int.Parse(stt) + 1;
                if (so < 10)
                {
                    mdh += "00" + so;
                }
                else if (so < 100)
                {
                    mdh += "0" + so;
                }
                else
                    mdh += so;
            }
            return mdh;
        }
        private void btn_ht_Click(object sender, EventArgs e)
        {
            string mdh = TaoMaDH();
            string sql = "INSERT INTO DONHANG VALUES ('" + mdh + "','" + lb_ba.Text + "'," + lb_tt.Text + ")";
            db.getNonquery(sql);
            for (int i = 0; i < table_order.Rows.Count - 1; i++)
            {
                DataGridViewRow r = table_order.Rows[i];
                string sql1 = "INSERT INTO CTDONHANG VALUES ('" + mdh + "','" + r.Cells["MAMONAN"].Value.ToString() + "'," + int.Parse(r.Cells["SOLUONG"].Value.ToString()) + "," + double.Parse(r.Cells["DONGIA"].Value.ToString()) + ")";
                db.getNonquery(sql1);
            }
            MessageBox.Show("Đã thêm đơn hàng thành công");
            DonHang f = new DonHang(lb_ba.Text, double.Parse(lb_tt.Text), lb_mnv.Text, lb_tnv.Text);
            f.Show();
            load_banan();
            table_order.Rows.Clear();
        }

        

        private void btn_dh_Click(object sender, EventArgs e)
        {
            DonHang f = new DonHang("", 0, lb_mnv.Text, lb_tnv.Text);
            f.Show();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            this.reload();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CTDONHANG VALUES ('" + cbo_dh.SelectedValue + "','" + txt_mma.Text.TrimEnd() + "'," + txt_sl.Text + "," + txt_dg.Text + ")";
            db.getNonquery(sql);
            string sql2 = "UPDATE DONHANG SET TONGTIEN = (SELECT SUM(SOLUONG*DONGIA) FROM CTDONHANG WHERE DONHANG.MADH=CTDONHANG.MADH)";
            db.getNonquery(sql2);
            MessageBox.Show("Đã thêm món ăn cho đơn hàng " + cbo_dh.SelectedValue.ToString()) ;
        }
    }
}
