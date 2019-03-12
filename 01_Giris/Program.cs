using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Değişken Tanımlama
            //int x = 15;
            //float y = 3.5;
            //double pi = 3.14;
            //bool isTrue = true;
            //char z = 'd';
            //string name = "derya"; 
            #endregion

            #region Ekrana Mesaj Yazdırma
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();
            #endregion

            #region Kullanıcıdan Veri Alma 1. Yöntem
            //string kullaniciAdi;
            //Console.WriteLine("İsminiz nedir?");
            //kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Hello " + kullaniciAdi + "!");
            //Console.ReadKey();
            #endregion

            #region Kullanıcıdan Veri Alma 2. Yöntem
            //string kullaniciAdi;
            //Console.WriteLine("İsminiz nedir?");
            //kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Hello {0}!", kullaniciAdi);
            //Console.ReadKey();
            #endregion

            #region Kullanıcıdan Veri Alma 3. Yöntem
            //string kullaniciAdi;
            //Console.WriteLine("İsminiz nedir?");
            //kullaniciAdi = Console.ReadLine();
            //Console.WriteLine($"Hello {kullaniciAdi}");
            //Console.ReadKey();
            #endregion

            string kullaniciAdi;
            int kullaniciYasi;
            Console.WriteLine("İsminiz nedir?");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Merhaba {0}! Yaşınızı girer misiniz?", kullaniciAdi);
            kullaniciYasi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yaşınız {0}", kullaniciYasi);
            Console.ReadKey();

        }
    }
}
