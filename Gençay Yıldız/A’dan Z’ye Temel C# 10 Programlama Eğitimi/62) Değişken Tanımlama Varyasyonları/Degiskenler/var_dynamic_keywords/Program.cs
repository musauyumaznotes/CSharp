using System;

namespace var_dynamic_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Var Keywordü
            //Tutulacak değerin türüne uygun bir değişken tanımlayabilmek için kullanilan keyword'dur.
            //var keyword'u' kendisine atanan değerin türüne bürünür 
            //Var keyword'ü compiler tarafından  değerin türüne göre otomatik büründürülen bir keyword'dür.Lakin bir tür DEĞİLDİR.,
            //Farklı diller arasında desteklenmeyen türlerdeki verileri karşılayabilmek için oluşturulmuş ortak bir keyword'dür

            string adi = "Musa";
            var x = 3.14m;
            //1. var keywordüyle tanımlanan değişkenin değeri tanımlanma aşamasında verilmelidir.Verilmelidir ki türü belirleyipğ direkt ona dönüşebilsin o türde davranış sergileyebilsin...
            //2. var keywordüyle tanımlanan değişkene ilk eğer verildikten sonra o değerin türüne bürüneceği için sonraki durumlarda değeri farklı türlerde verilemez!!!
            //Compiler aşamasında çalışan operasyonel bir keyworddür.
            //3. var - object arasındaki farkı;
            //var bir keyword iken object ise bir türdür.var atanan değerin tipine bürünürken, object atanan değeri Boxing yaparak object'te dönüştürür.
            #endregion
            #region dynamic
            //var a = 5;
            //a.ToString();
            dynamic _a = 5;
            //_a.ToString();
            Console.WriteLine(_a.GetType());
            Console.WriteLine(_a * 5);

            //dynamic keywordü runtime'da türü belirleyecektir lakin kararlı davranmayacaktır.
            //Runtime'da esnek çalışmamızı sağlar.
            dynamic y = "Ahmet";
            Console.WriteLine(y.GetType());
            y = 3.14D;
            Console.WriteLine(y.GetType());
            #endregion

            //Dynamic Nerelerde Tercih edilir ?? 


        }
    }
}
