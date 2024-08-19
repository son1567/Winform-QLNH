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
    public partial class QL_BanAn : Form
    {
        ConnectDB db = new ConnectDB();
        DataTable dt;
        public QL_BanAn()
        {
            InitializeComponent();
        }

        void load_BanAn()
        {
            string sql = "SELECT * FROM BANAN";
            dt = db.getTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["MABAN"];
            dt.PrimaryKey = key;
            table_banan.DataSource = dt;
        }
        void DataBinding(DataTable dt)
        {
            txt_maba.DataBindings.Clear();
            txt_scn.DataBindings.Clear();
            txt_maba.DataBindings.Add("Text", dt, "MABAN");
            txt_scn.DataBindings.Add("Text", dt, "SOCN");
        }
        private void QL_BanAn_Load(object sender, EventArgs e)
        {
            load_BanAn();
            DataBinding(dt);
        }
        bool ktratrung(string ma)
        {
            ConnectDB db = new ConnectDB();

            string sql = "SELECT COUNT(*) FROM BANAN WHERE MABAN = '" + ma + "'";

            if (db.getScalar(sql) == 0)
                return true;
            else
                return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ktratrung(txt_maba.Text))
            {
                db.Open();
                string sql = "INSERT INTO BANAN VALUES ('"+txt_maba.Text+"',"+txt_scn.Text+")";
                db.Close();
                if (db.getNonquery(sql) == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    load_BanAn();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mã bàn ăn đã tồn tại");
            }
            DataBinding(dt);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = table_banan.SelectedRows[0];
            object value = row.Cells[0].Value;
            string vl = value.ToString();
            db.Open();
            string sql = "UPDATE BANAN SET MABAN = '" + txt_maba.Text + "', SOCN = " + txt_scn.Text + " WHERE MABAN = '" + vl + "'";
            db.Close();
            if (db.getNonquery(sql) == 1)
            {
                MessageBox.Show("Sửa thành công");
                load_BanAn();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            DataBinding(dt);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_maba.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            string sql = "SELECT * FROM BANAN";
            int k = db.UpdateTable(dt, sql);
            if (k != 0)
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Chưa xóa");

            DataBinding(dt);
        }

        private void QL_BanAn_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
