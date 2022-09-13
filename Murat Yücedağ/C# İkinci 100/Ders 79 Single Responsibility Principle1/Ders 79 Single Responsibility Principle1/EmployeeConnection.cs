using System.Data.SqlClient;

namespace Ders_79_Single_Responsibility_Principle1
{
    public class EmployeeConnection
    {
        public static SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
            return con;
        }
    }
}
