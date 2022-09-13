using System;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1'den 100'e kadar say...");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("1'den 100'e kadar say...");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("1'den 100'e kadar say...");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
