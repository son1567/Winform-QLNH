using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QL_NHAHANG
{
    class ConnectDB
    {
        public string ck = "Data Source = LAPTOP-L9CTVHLO; database = QL_NHAHANGN; Integrated Security = true";
        SqlConnection con;
        public ConnectDB()
        {
            con = new SqlConnection(ck);
        }
        public ConnectDB(string ckn)
        {
            con = new SqlConnection(ckn);
        }

        //Xử lý dữ liệu
        public void Open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //phương thức
        public int getNonquery(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public int getScalar(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public DataTable getTable(string sql)
        {
            Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public int UpdateTable(DataTable dt, string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
    }
}
