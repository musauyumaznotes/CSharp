using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_79_Single_Responsibility_Principle1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDef emp = new EmployeeDef();
            emp.EmployeeList();
            emp.Process();
            Console.ReadLine();
        }
    }
}
