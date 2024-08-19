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
    public partial class QL_MonAn : Form
    {
        public QL_MonAn()
        {
            InitializeComponent();
        }
        ConnectDB db = new ConnectDB();
        DataTable dt;
        void load_DMMA()
        {
            string sql = "SELECT * FROM LOAISP";
            DataTable dt1 = db.getTable(sql);
            DataRow dr = dt1.NewRow();
            dr["MALOAI"] = "All";
            dr["TENLOAI"] = "Tất cả";
            dt1.Rows.InsertAt(dr, 0);
            cmb_dmma.DataSource = dt1;
            cmb_dmma.DisplayMember = "TENLOAI";
            cmb_dmma.ValueMember = "MALOAI";
        }

        void load_MonAn()
        {
            string sql = "SELECT * FROM THUCDON";
            dt = db.getTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MASP"];
            dt.PrimaryKey = key;
            table_monan.DataSource = dt;
        }

        void load_loai()
        {
            string sql = "SELECT * FROM LOAISP";
            DataTable dt1 = db.getTable(sql);
            cmb_loai.DataSource = dt1;
            cmb_loai.DisplayMember = "TENLOAI";
            cmb_loai.ValueMember = "MALOAI";
        }
        void DataBinding(DataTable dt)
        {
            txt_ma.DataBindings.Clear();
            txt_ten.DataBindings.Clear();
            cmb_loai.DataBindings.Clear();
            txt_dvt.DataBindings.Clear();
            txt_dg.DataBindings.Clear();
            txt_ma.DataBindings.Add("Text", dt, "MASP");
            txt_ten.DataBindings.Add("Text", dt, "TENSP");
            cmb_loai.DataBindings.Add("SelectedValue", dt, "MALOAI");
            txt_dvt.DataBindings.Add("Text", dt, "DVT");
            txt_dg.DataBindings.Add("Text", dt, "DONGIA");
        }
        private void QL_MonAn_Load(object sender, EventArgs e)
        {
            load_DMMA();
            load_loai();
            load_MonAn();
            DataBinding(dt);
        }
        private void cmb_dmma_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM THUCDON WHERE MALOAI = '"+cmb_dmma.SelectedValue+"'";
            if (cmb_dmma.SelectedValue.ToString() == "All")
            {
               dt1 = db.getTable("SELECT * FROM THUCDON");
            }
            else
               dt1 = db.getTable(sql);
            table_monan.DataSource = dt1;
            DataBinding(dt1);
        }

        bool ktratrung(string ma)
        {
            ConnectDB db = new ConnectDB();

            string sql = "SELECT COUNT(*) FROM THUCDON WHERE MASP = '" + ma + "'";

            if (db.getScalar(sql) == 0)
                return true;
            else
                return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ktratrung(txt_ma.Text))
            {
                db.Open();
                string sql = "Insert INTO THUCDON Values ('" + txt_ma.Text + "',N'" + txt_ten.Text + "','" + cmb_loai.SelectedValue + "',N'"+txt_dvt.Text+"','" + txt_dg.Text + "')";
                db.Close();
                if (db.getNonquery(sql) == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    load_MonAn();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mã món ăn đã tồn tại");
            }
            DataBinding(dt);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_ma.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            string sql = "SELECT * FROM THUCDON";
            int k = db.UpdateTable(dt, sql);
            if (k != 0)
            {
                MessageBox.Show("Đã xóa");
                load_MonAn();
            }
            else
                MessageBox.Show("Chưa xóa");

            DataBinding(dt);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = table_monan.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            db.Open();
            string sql = "UPDATE THUCDON SET MASP = '" + txt_ma.Text + "', TENSP = N'" + txt_ten.Text + "',MALOAI=N'" + cmb_loai.SelectedValue + "',DVT=N'" + txt_dvt.Text + "',DONGIA='" + txt_dg.Text + "' WHERE MASP = '" + vl + "'";
            db.Close();
            if (db.getNonquery(sql) == 1)
            {
                MessageBox.Show("Sửa thành công");
                load_MonAn();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            DataBinding(dt);
        }

        private void QL_MonAn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataTable dt1;
            string sql = "SELECT * FROM THUCDON WHERE TENSP like N'%"+txt_tenmonan.Text+"%'";
            dt1 = db.getTable(sql);
            table_monan.DataSource = dt1;
            DataBinding(dt1);
        }

        
    }
}
