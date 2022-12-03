using System;

namespace DRY2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Say();
            Say();
            Say();
        }

        static void Say()
        {
            Console.WriteLine("1'den 100'e kadar say...");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
