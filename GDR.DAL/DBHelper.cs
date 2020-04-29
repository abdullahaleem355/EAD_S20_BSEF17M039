using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDR.DAL
{
    public class DBHelper : IDisposable
    {
        String _connStr = "Data Source=.\\SQLEXPRESS2014;Initial Catalog = Assignment5; User Id = sa; Password=PakistanZindabad;";
        /*System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;*/

        SqlConnection _conn = null;

        public DBHelper()
        {
            _conn = new SqlConnection(_connStr);
            _conn.Open();
        }

        public int ExecuteQuery(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            var count = command.ExecuteNonQuery();
            return count;
        }

        public Object ExecuteScalar(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            return command.ExecuteScalar();
        }

        public SqlDataReader ExecuteReader(String sqlQuery)
        {
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}
