using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace login2
{
    class DBConnect
    {
        SqlConnection sql;
        public DBConnect()
        {

            sql = new SqlConnection("Data Source=LAPTOP-AUIVJ6IL;Initial Catalog=QUANLI_TH_SPA;Integrated Security=True");
        }
        public void Open()
        {
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();

            }
        }
        public void Close()
        {
            if (sql.State == ConnectionState.Open)
            {
                sql.Close();
            }
        }
        public int GetNonQuery(string sql1)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql1, sql);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public SqlDataReader getDataReader(string sql1)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql1, sql);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public object getCsalar(string insert)
        {
            Open();
            SqlCommand cmd = new SqlCommand(insert, sql);
            object kq = cmd.ExecuteScalar();
            return kq;
        }
        public DataSet getDatatable(string sql1,string tenbang)
        {
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql1, sql);
            da.Fill(dt,tenbang);
            return dt;
        }

        public int updateDatabase(DataTable dt, string sql1)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql1, sql);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
    }
}
