using System;

namespace Sabitler
{
    internal class Program
    {
        //Bir değişken class scope içerisinde tanımlanıyorsa buna global değişken diyoruz...
        //Baz aldığınız scope'a göre değişkenler local ya da global olur. 
        int a;//Global değişken
        int b;
        int c;
        static void Main(string[] args)
        {
            int z;
            {

            }
            {
                {

                }
            }
        }
    }
}
