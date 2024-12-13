using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleCoop
{
    internal class Function
    {
        public Function()
        {

        }

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Ketnoi.getConnect())
            {
                sqlConnection.Open();
                SqlCommand thucthi = new SqlCommand(query, sqlConnection);
                SqlDataReader data = thucthi.ExecuteReader();
                while (data.Read())
                {
                    taiKhoans.Add(new TaiKhoan(data.GetString(0), data.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Ketnoi.getConnect())
            {
                sqlConnection.Open();
                sqlConnection.Close();
                SqlCommand thucthi = new SqlCommand(query, sqlConnection);
                thucthi.ExecuteNonQuery();

            }
        }
    }
}
