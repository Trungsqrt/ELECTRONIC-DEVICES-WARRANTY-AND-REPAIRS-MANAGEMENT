using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDWARM
{
    internal class DatabaseHandle
    {
        SqlConnection conn;
        public DatabaseHandle()
        {
            conn = new SqlConnection(ConnectionString.conn);
        }

        public SqlConnection getConnectionString()
        {
            return conn;
        }

        public DataTable loadTable(SqlCommand cmd)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public void exNonQuery(SqlCommand cmd)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int exScala(SqlCommand cmd)
        {
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }

        public DataTable LoadBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
