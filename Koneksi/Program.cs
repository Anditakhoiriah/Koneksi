using System;
using System.Data.SqlClient;

namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=ANDITAKHRH\\ANDITAKHRH;database=ProdiTI;Integrated Security=true")
            )
            {
                con.Open();
                Console.WriteLine("Berhasil Terhubung Ke database!");
            }
        }
    }
}
