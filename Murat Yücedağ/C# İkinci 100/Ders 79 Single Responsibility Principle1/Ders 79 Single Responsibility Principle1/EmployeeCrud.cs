using System;
using System.Data.SqlClient;

namespace Ders_79_Single_Responsibility_Principle1
{
    class EmployeeCrud
    {
        public void EmployeeAdd(EmployeeDef employee)
        {
            EmployeeConnection.Connection().Open();
            SqlCommand commandAdd = new SqlCommand("insert into Employees(FirstName,LastName,City) values(@p1,@p2,@p3)",EmployeeConnection.Connection());
            commandAdd.Parameters.AddWithValue("@p1",employee.EmployeeName);
            commandAdd.Parameters.AddWithValue("@p1", employee.EmployeeSurname);
            commandAdd.Parameters.AddWithValue("@p1", employee.City);
            commandAdd.ExecuteNonQuery();
            EmployeeConnection.Connection().Close();
        }
        public void EmployeeList()
        {

            EmployeeConnection.Connection().Open();
            SqlCommand komut = new SqlCommand("select * from Employees", EmployeeConnection.Connection());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Id: " + dr[0] + " Name: " + dr[2] + " Surname: " + dr[1] + " City: " + dr[8]);
            }
            EmployeeConnection.Connection().Close();
        }
    }
}
