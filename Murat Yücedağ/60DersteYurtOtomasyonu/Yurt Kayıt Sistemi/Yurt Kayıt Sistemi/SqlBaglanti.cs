using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Yurt_Kayıt_Sistemi
{
    public class SqlBaglanti
    {
        public SqlConnection Baglan()
        {
            SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=YurtKayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        public SqlConnection Cikis(SqlConnection connection)
        {
            connection.Close();
            return connection;
        }
    }
}
