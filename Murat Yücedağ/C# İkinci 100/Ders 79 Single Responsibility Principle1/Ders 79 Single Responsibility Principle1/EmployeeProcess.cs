using System;

namespace Ders_79_Single_Responsibility_Principle1
{
    public class EmployeeProcess
    {
        public void Process()
        {
            Console.WriteLine("**** Single Responsibility Principle Example ****");
            Console.BackgroundColor = ConsoleColor.Yellow;
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
