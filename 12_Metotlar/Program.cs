using System;

namespace _12_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pass by value
            int sayi = 50;
            string deger = "ESKİ";

            Console.WriteLine("Before value type {0}", sayi);
            Console.WriteLine("Before reference type {0}", deger);
            Console.WriteLine("-----------");

            PassValueType(sayi);
            PassReferenceType(deger);

            Console.WriteLine("After value type {0}", sayi);
            Console.WriteLine("After reference type {0}", deger);
            Console.WriteLine("-----------");
            #endregion

            #region REF
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            int number = 10;
            Console.WriteLine("Önce: {0}", number);
            Change(ref number);
            Console.WriteLine("Sonra: {0}", number);
            number = 158;
            Console.WriteLine("Main Değişim: {0}", number);
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region REF Örnek
            //Stringlerin değerlerini değiştirmek
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            string value1 = "Kedi", value2 = "Köpek";
            Console.WriteLine("Before: {0} - {1}", value1, value2);
            Swap(ref value1, ref value2);
            Console.WriteLine("After: {0} - {1}", value1, value2);
            Console.WriteLine();
            Console.WriteLine("------------");
            #endregion

            #region Array Resize Method
            //Array'in boyutunu girilen değer kadar arttırmak
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            int[] numbers = { 1, 96, 36, 21, 10, 3 };
            Console.WriteLine("Array Size: {0}", numbers.Length);
            ArrayResize(ref numbers, 10);
            Console.WriteLine("New Array Size: {0}", numbers.Length);
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region OUT
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            char letter;
            string text = GetWordAndFirstLetter(out letter);
            Console.WriteLine($"İlk Harf: {letter}");
            Console.WriteLine($"Metin: {text}");
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region OUT Örnek
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            //Kullanıcıdan alınan sayının tam kısmı ile ondalık kısmını ayırmak
            Console.Write("Parçalanacak Ondalıklı Sayı: ");
            decimal num = decimal.Parse(Console.ReadLine());
            decimal floating;
            int integer = GetParts(num, out floating);
            Console.WriteLine("Tam Kısım = {0}  -  Ondalıklı Kısım = {1}", integer, floating);
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region Custom TryParse
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            //Kendi TryParse Metotumuzu Yazma
            Console.WriteLine("Bir sayı giriniz: ");
            string value = Console.ReadLine();
            int numberVal;
            bool isConverted = TryParse(value, out numberVal);
            if (isConverted)
            {
                Console.WriteLine("Girdiğiniz değer int çevirildi. {0}", numberVal);
            }
            else
            {
                Console.WriteLine("Girdiğiniz değer çevrilemedi");
            }
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region Method Overloading
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            Console.WriteLine("1. Metot: {0} ", Toplama(1,5));
            Console.WriteLine("2. Metot: {0} ", Toplama(101.65,5.5));
            Console.WriteLine("3. Metot: {0} ", Toplama(78,52,74));
            Console.WriteLine("4. Metot: {0} ", Toplama(125, 74, 25));
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region Method Overloading Örneği
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            SendMail("dunya@mail.com", "mars@mail.com", "Merhaba", "Merhaba Dünya!");
            string[] to = { "ali@mail.com", "ayse@mail.com", "bulent@mail.com" };
            SendMail(to, "derya@mail.com", "Toplantı", "Toplantı 1 saat sonraya ertelenmiştir");
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region Recursive Metotlar
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            Console.WriteLine("Kaçıncı Fibonacci sayısını görmek istiyorsunuz?");
            int order = int.Parse(Console.ReadLine());
            Console.WriteLine($"{order}. Fibonacci Sayısı: {Fibonacci(order)}");
            Console.WriteLine();
            Console.WriteLine("-----------");
            #endregion

            #region Recursive Faktöriyel
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
            Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            int factorial = int.Parse(Console.ReadLine());
            Console.WriteLine($"{factorial}! = {Factorial(factorial)}");
            Console.WriteLine();
            Console.WriteLine("-----------");

            #endregion

            #region Recursive Pascal
            Console.Write("Görmek istediğiniz satır: ");
            int row = int.Parse(Console.ReadLine());
            int[] pascal = Pascal(row);
            foreach (int item in pascal)
            {
                Console.WriteLine(item + " ");
            }
            #endregion

            Console.ReadKey();
        }

        #region Pass by value
        static void PassValueType(int deger)
        {
            deger = 100;
        }

        static void PassReferenceType(string deger)
        {
            deger = "Yeni";
        }
        static void PassObject(object deger)
        {
            deger = "Yeni obje";
        }
        #endregion

        #region REF Metot
        static void Change(ref int number)
        {
            number = 50;
        }
        #endregion

        #region REF Örnek
        static void Swap(ref string text1, ref string text2)
        {
            string temp = string.Empty;

            temp = text1;
            text1 = text2;
            text2 = temp;
        }
        #endregion

        #region Array Resize
        static void ArrayResize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        #endregion

        #region OUT
        static string GetWordAndFirstLetter(out char letter)
        {
            string quote = "Kendin ol, diğer herkesten zaten çokça var. O.W";
            letter = quote[0];
            return quote;
        }
        #endregion

        #region OUT Örnek
        static int GetParts(decimal value, out decimal floating)
        {
            int number = (int)value;
            floating = value - number;
            return number;
        }
        #endregion

        #region Custom TryParse
        static bool TryParse(string value, out int number)
        {
            try
            {
                number = int.Parse(value);
                return true;
            }
            catch
            {
                number = 0;
                return false;
            }
        }
        #endregion

        #region Method Overloading

        static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static double Toplama(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Toplama(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static decimal Toplama(params int[] sayilar)
        {
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam;
        }
        #endregion

        #region Method Overloading
        static void SendMail(string to, string from, string subject, string message)
        {
            Console.WriteLine($"{to} kişisine {from} kişisinden {subject} konulu bir mail gönderildi");
        }

        static void SendMail(string[] to, string from, string subject, string message)
        {
            foreach (string item in to)
            {
                Console.WriteLine($"{item} kişisine {from} kişisinden {subject} konulu bir mail gönderildi");
            }
        }
        #endregion

        #region Recursive Metotlar
        static int Fibonacci(int order)
        {
            if (order == 1)
            {
                return 1;
            }
            else if (order == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(order - 1) + Fibonacci(order - 2);
            }
        }
        #endregion

        #region Recursive Örnek
        static int Factorial(int number)
        {
            int result;

            if (number == 0)
            {
                result = 1;
            }
            else
            {
                result = number * Factorial(number - 1);
            }

            return result;
        }
        #endregion

        #region Recursive Pascal
        static int[] Pascal(int row)
        {
            int[] items = new int[row];
            items[0] = 1;
            items[row - 1] = 1;

            if (row > 2)
            {
                int[] prevItems = Pascal(row - 1);
                for (int i = 1; i < prevItems.Length; i++)
                {
                    items[i] = prevItems[i - 1] + prevItems[i];
                }
            }

            return items;
        }
        #endregion
    }
}
