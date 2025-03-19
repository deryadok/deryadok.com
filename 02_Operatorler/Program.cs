using System;

namespace _02_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region var Keyword
            //var num = 15;
            //var num;
            //num = 15; 
            #endregion

            #region Sabitler
            //const double PI = 3.14;
            #endregion

            #region Toplama
            //int x = 10 + 4;
            //Console.WriteLine(x);
            #endregion

            #region Çıkarma
            //int x = 10 - 4;
            //Console.WriteLine(x);
            #endregion

            #region Çarpma
            //int x = 10 * 4;
            //Console.WriteLine(x);
            #endregion

            #region Bölme
            //int x = 10 / 4;
            //Console.WriteLine(x);
            #endregion

            #region Mod
            //int x = 10 % 4;
            //Console.WriteLine(x);
            #endregion

            #region Arttırma
            int postfix = 1, prefix = 1;
            int x = postfix++;
            int y = ++prefix;
            #endregion

            #region Operatör Önceliği
            //int x = 4 + 3 * 2;
            //Console.WriteLine(x);

            //int x = (4 + 3) * 2;
            //Console.WriteLine(x);
            #endregion

            Console.ReadKey();
        }
    }
}
