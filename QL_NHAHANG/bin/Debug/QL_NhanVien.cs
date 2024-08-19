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
    public partial class QL_NhanVien : Form
    {
        ConnectDB db = new ConnectDB();
        DataTable dt;
        public QL_NhanVien()
        {
            InitializeComponent();
        }

        void Load_NhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            dt = db.getTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MANV"];
            dt.PrimaryKey = key;
            table_nhanvien.DataSource = dt;
        }
        void DataBinding(DataTable t)
        {
            txt_manv.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            cmb_gioitinh.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_dienthoai.DataBindings.Clear();
            ngaysinh.DataBindings.Clear();
            ngayvaolam.DataBindings.Clear();
            cmb_chucvu.DataBindings.Clear();
            cmb_calam.DataBindings.Clear();
            txt_mk.DataBindings.Clear();

            txt_manv.DataBindings.Add("Text", t, "MANV");
            txt_hoten.DataBindings.Add("Text", t, "TENNV");
            cmb_gioitinh.DataBindings.Add("SelectedValue", t, "GTINH");
            txt_diachi.DataBindings.Add("Text", t, "DIACHI");
            txt_dienthoai.DataBindings.Add("Text", t, "DTHOAI");
            ngaysinh.DataBindings.Add("Value", t, "NGAYSINH");
            ngayvaolam.DataBindings.Add("Value", t, "NGAYVL");
            cmb_chucvu.DataBindings.Add("SelectedValue", t, "MACV");
            cmb_calam.DataBindings.Add("SelectedValue", t, "TENCA");
            txt_mk.DataBindings.Add("Text", t, "MATKHAU");
        }
        void load_GT()
        {
            string sql = "SELECT DISTINCT GTINH FROM NHANVIEN";
            DataTable dt1 = db.getTable(sql);
            cmb_gioitinh.DataSource = dt1;
            cmb_gioitinh.DisplayMember = "GTINH";
            cmb_gioitinh.ValueMember = "GTINH";
            //Lọc theo giới tính
            DataTable dt2 = db.getTable(sql);
            DataRow dr = dt2.NewRow();
            dr["GTINH"] = "Tất cả";
            dt2.Rows.InsertAt(dr, 0);
            cbo_locgt.DataSource = dt2;
            cbo_locgt.DisplayMember = "GTINH";
            cbo_locgt.ValueMember = "GTINH";
        }
       
        void load_Chucvu()
        {
            string sql = "SELECT * FROM CHUCVU";
            DataTable dt1 = db.getTable(sql);
            cmb_chucvu.DataSource = dt1;
            cmb_chucvu.DisplayMember = "TENCV";
            cmb_chucvu.ValueMember = "MACV";
            //Lọc theo chức vụ
            DataTable dt2 = db.getTable(sql);
            DataRow dr = dt2.NewRow();
            dr["MACV"] = "All";
            dr["TENCV"] = "Tất cả";
            dt2.Rows.InsertAt(dr, 0);
            cbo_loccv.DataSource = dt2;
            cbo_loccv.DisplayMember = "TENCV";
            cbo_loccv.ValueMember = "MACV";
        }
        void load_Calam()
        {
            string sql = "SELECT TENCA  FROM CALAM";
            DataTable dt1 = db.getTable(sql);
            cmb_calam.DataSource = dt1;
            cmb_calam.DisplayMember = "TENCA";
            cmb_calam.ValueMember = "TENCA";
            //Lọc theo ca làm
            DataTable dt2 = db.getTable(sql);
            DataRow dr = dt2.NewRow();
            dr["TENCA"] = "Tất cả";
            dt2.Rows.InsertAt(dr, 0);
            cbo_locca.DataSource = dt2;
            cbo_locca.DisplayMember = "TENCA";
            cbo_locca.ValueMember = "TENCA";
        }
        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            load_Calam();
            load_Chucvu();
            load_GT();
            Load_NhanVien();
            DataBinding(dt);
        }

        bool ktratrung(string ma)
        {
            ConnectDB db = new ConnectDB();

            string sql = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = '"+ma+"'";

            if (db.getScalar(sql) == 0)
                return true;
            else
                return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ktratrung(txt_manv.Text))
            {
                db.Open();
                string sql = "Insert INTO NHANVIEN Values ('" + txt_manv.Text + "',N'" + txt_hoten.Text + "',N'" + cmb_gioitinh.SelectedValue + "',N'" + txt_diachi.Text + "','" + txt_dienthoai.Text + "','" + string.Format("{0:yyyyMMdd}", ngaysinh.Value) + "','" + string.Format("{0:yyyyMMdd}", ngayvaolam.Value) + "','" + cmb_chucvu.SelectedValue + "',N'" + cmb_calam.SelectedValue + "','" + txt_mk.Text + "')";
                db.Close();
                if (db.getNonquery(sql) == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    Load_NhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            DataBinding(dt);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_manv.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            string sql = "SELECT * FROM NHANVIEN";
            int k = db.UpdateTable(dt, sql);
            if (k != 0)
            {
                MessageBox.Show("Đã xóa");
                Load_NhanVien();
            }
            else
                MessageBox.Show("Chưa xóa");
            DataBinding(dt);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = table_nhanvien.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            db.Open();
            string sql = "UPDATE NHANVIEN SET MANV = '" + txt_manv.Text + "', TENNV = N'" + txt_hoten.Text + "',GTINH=N'" + cmb_gioitinh.SelectedValue + "',DIACHI=N'" + txt_diachi.Text + "',DTHOAI='" + txt_dienthoai.Text + "', NGAYSINH='" + string.Format("{0:yyyyMMdd}", ngaysinh.Value) + "',NGAYVL='" + string.Format("{0:yyyyMMdd}", ngayvaolam.Value) + "',MACV='" + cmb_chucvu.SelectedValue + "',TENCA=N'" + cmb_calam.Text + "', MATKHAU='" + txt_mk.Text + "' WHERE MANV = '" + vl + "'";
            db.Close();
            if (db.getNonquery(sql) == 1)
            {
                MessageBox.Show("Sửa thành công");
                Load_NhanVien();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            DataBinding(dt);
        }

        private void QL_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbo_locgt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM NHANVIEN WHERE GTINH = N'"+cbo_locgt.SelectedValue+"'";
            if (cbo_locgt.SelectedValue.ToString() == "Tất cả")
            {
                dt1 = db.getTable("SELECT * FROM NHANVIEN");
            }
            else
                dt1 = db.getTable(sql);
            table_nhanvien.DataSource = dt1;
            DataBinding(dt1);
        }

        private void cbo_loccv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM NHANVIEN WHERE MACV = '" + cbo_loccv.SelectedValue + "'";
            if (cbo_loccv.SelectedValue.ToString() == "All")
            {
                dt1 = db.getTable("SELECT * FROM NHANVIEN");
            }
            else
                dt1 = db.getTable(sql);
            table_nhanvien.DataSource = dt1;
            DataBinding(dt1);
        }

        private void cbo_locca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM NHANVIEN WHERE TENCA = N'" + cbo_locca.SelectedValue + "'";
            if (cbo_locca.SelectedValue.ToString() == "Tất cả")
            {
                dt1 = db.getTable("SELECT * FROM NHANVIEN");
            }
            else
                dt1 = db.getTable(sql);
            table_nhanvien.DataSource = dt1;
            DataBinding(dt1);
        }
        string TaoMaNV()
        {
            string mpn = "NV";
            string sql = "SELECT top 1 * FROM NHANVIEN Where MANV like 'NV%' Order by MANV desc";
            DataTable dt1 = db.getTable(sql);
            if (dt1.Rows.Count == 0)
            {
                mpn += "001";
            }
            else
            {
                string mbd = dt1.Rows[0]["MANV"].ToString();
                string stt = mbd.Substring(mbd.Length - 3);
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
        private void btn_tao_Click(object sender, EventArgs e)
        {
            txt_manv.Text = TaoMaNV();
            txt_hoten.Clear();
            txt_diachi.Clear();
            txt_dienthoai.Clear();
            txt_mk.Clear();
        }
    }
}
