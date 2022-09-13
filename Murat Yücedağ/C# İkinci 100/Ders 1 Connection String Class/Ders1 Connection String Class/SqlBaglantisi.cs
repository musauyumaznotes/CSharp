using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ders1_Connection_String_Class
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=kutuphane1;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
