using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleCoop
{
    internal class Ketnoi
    {
        private static string connectionString = @"Data Source=DESKTOP-HCU3M67\SQLEXPRESS;Initial Catalog=QLBH_Coop;Persist Security Info=True;User ID=sa;Password=110911;Encrypt=False;TrustServerCertificate=True";
        public static SqlConnection getConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
