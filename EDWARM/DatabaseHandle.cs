using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thao tác");
            }
        }

        public int exScala(string query)
        {
            conn.Close();
            SqlCommand comm = new SqlCommand(query, conn);
            conn.Open();
            var kq = comm.ExecuteScalar().ToString();
            conn.Close();
            int result = 0;
            if (int.TryParse(kq, out result));
            return result;
        }

        public DataTable LoadBang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public object Login(SqlCommand cmd)
        {
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            return result;
        }
    }
}
