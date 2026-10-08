using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    public class ConnectDB
    {
        public static string connectionString =
            @"Data Source=TANGDZVL\SQLEXPRESS;
              Initial Catalog=QLSV;
              Integrated Security=True;
              TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
   
}
