using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Metotlar_Giris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("1 Toplama");
            Console.WriteLine("2 Çıkarma");
            Console.WriteLine("3 Çarpma");
            Console.WriteLine("4 Bölme");
            short secim = short.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("İlk sayı: ");
                    int tsayi1 = int.Parse(Console.ReadLine());
                    Console.Write("İkinci sayı: ");
                    int tsayi2 = int.Parse(Console.ReadLine());
                    int toplama = Addition(tsayi1, tsayi2);
                    Console.WriteLine("Sonuç: {0}", toplama);
                    break;
                case 2:
                    Console.Write("İlk sayı: ");
                    int csayi1 = int.Parse(Console.ReadLine());
                    Console.Write("İkinci sayı: ");
                    int csayi2 = int.Parse(Console.ReadLine());
                    int cikarma = Subtraction(csayi1, csayi2);
                    Console.WriteLine("Sonuç: {0}", cikarma);
                    break;
                case 3:
                    Console.Write("İlk sayı: ");
                    int cpsayi1 = int.Parse(Console.ReadLine());
                    Console.Write("İkinci sayı: ");
                    int cpsayi2 = int.Parse(Console.ReadLine());
                    int carpim = Multiplication(cpsayi1, cpsayi2);
                    Console.WriteLine("Sonuç: {0}", carpim);
                    break;
                case 4:
                    Console.Write("İlk sayı: ");
                    int bsayi1 = int.Parse(Console.ReadLine());
                    Console.Write("İkinci sayı: ");
                    int bsayi2 = int.Parse(Console.ReadLine());
                    double bolme = 0;
                    if (bsayi2 > 0)
                    {
                        bolme = Division(bsayi1, bsayi2);

                    }
                    Console.WriteLine("Sonuç: {0}", bolme);
                    break;
                default:
                    Console.WriteLine("Yanlış tuşa bastınız :(");
                    break;
            }

            int toplam = Sum(12, 36, 32, 8, 7, 3);
            Console.WriteLine("Toplam {0}", toplam);
            Console.WriteLine();
            Console.ReadKey();
        }

        #region Metotlara Giriş - Geriye Değer Döndürmeyen Metotlar
        public static void HelloWorld()
        {
            Console.WriteLine("Merhaba Dünya!");
        }
        #endregion

        #region Parametresiz Metot
        public static void Toplama()
        {
            int a = 5;
            int b = 9;

            int sum = a + b;

            Console.WriteLine(sum);
        }
        #endregion

        #region Parametreli Metot
        public static void Toplam(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Toplam {0}", sum);
        }
        #endregion

        #region Geriye Değer Döndüren Metotlar
        public static string HelloUser(string user)
        {
            string message = "Merhaba " + user + "!";
            return message;
            //return "Merhaba " + user + "!"; //Tek satırda bu şekilde geriye değer döndürebiliriz.
        }
        #endregion

        #region Basit Hesap Makinesi
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            return a / b;
        }
        #endregion

        #region Detaylı Hesap Makinesi
        public static double Percentage(int a, int rate)
        {
            return (a * rate) / 100;
        }

        public static int Pow(int a, int b)
        {
            int pow = 1;

            for (int i = 1; i <= b; i++)
            {
                pow *= a;
            }

            return pow;
        }

        public static double Square(int a)
        {
            double root = 1;

            for (int i = 0; i < a + 1; i++)
            {
                root = (a / root + root) / 2;
            }

            return root;
        }
        #endregion

        #region params
        public static int Sum(params int[] number)
        {
            int a = 0;

            for (int i = 0; i < number.Length; i++)
            {
                a += number[i];
            }

            return a;
        }
        #endregion

        #region params Örneği
        public static void EkranaYaz(string format, params object[] values)
        {
            Console.WriteLine(format, values);
        }
        #endregion

        #region Opsiyonel Parametre
        public static int Power(int num, int pow = 1)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
        #endregion

        #region İsimlendirilmiş Parametre
        public static int Carpim(int num1, int num2)
        {
            return num1 * num2;
        }
        #endregion
    }
}
