using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WhileDonguYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İlk Örnek
            //int sayi = 1;
            //while (sayi <= 5)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //} 
            #endregion

            #region İkinci Örnek
            //int num = 1;
            //while (num < 6)
            //{
            //    Console.WriteLine(num);
            //    num += 2;
            //}
            #endregion

            #region Sonsuz Döngü
            //int num = 1;
            //while (true)
            //{
            //    Console.WriteLine(num);
            //    num += 2;
            //} 
            #endregion

            int num = 0;
            while (num++ < 6)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
