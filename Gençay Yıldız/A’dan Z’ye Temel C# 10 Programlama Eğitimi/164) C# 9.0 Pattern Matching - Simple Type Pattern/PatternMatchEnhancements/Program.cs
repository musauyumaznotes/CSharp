using System;

namespace PatternMatchEnhancements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple Type Pattern
            //Bir değişken içerisindeki değerin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlayan desendir.
            //C# 9.0'dan önce Type Pattern ile yapılan tür bildirimlerinin yanına değişken adı tanımlaması yahut discard ifadesinin kullanılaması zaruriydi. C# 9.0 ile bu gereksiz zorunluluk ortadan kaldırılmış ve direkt olarak tür kontrol işlemine odaklanılması sağlanmıştır.
            #endregion
            #region Relational Patterns
            //Desenlerde <,>,<= ve >= operatörleri kullanılabilmekte ve belirli karşılaştırmalar hızlıca gerçekleştirilebilmektedir.
            #region Kritik
            //Switch ile İf araasındaki fark nedir ? !!!Mülakat sorusu
            //switch normal eşitlik durumuna bakmakta if ise bütün karşılaştırmaları yapabilmektedir. Amma velakin relational pattern sayesinde artık switch sadece eşitlik durumuna değil tüm ihtimallere tüm karşılaştırma durumlarına bakabilmektedir.
            #endregion
            #endregion
            #region Logical Pattern
            //and,or ve not gibi mantıksal operatörler kullanılabilmektedir.
            //Reletaional Pattern ile oldukça uyumludur
            #endregion
            #region Not Patterns
            //not operatörünün kullanılabildiği bir desendir.
            #endregion
        }
    }
}
