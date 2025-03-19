using System;

namespace _13_ArrayMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 100);
            }

            Console.Write("Rastgele Nümerik Dizi: ");

            WriteArray(array);

            //char[] alphabetic = new char[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    alphabetic[i] = (char)rnd.Next(65, 91);
            //}

            //Console.WriteLine();
            //Console.Write("Rastgele Alfabetik Dizi: ");
            //WriteArray(alphabetic);
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            #region Sort
            ////Sort Metodu
            //Array.Sort(array);
            //Console.Write("Sıralı Nümerik Dizi: ");
            //WriteArray(array);

            //Console.WriteLine();

            //Array.Sort(alphabetic);
            //Console.Write("Sıralı Alfabetik Dizi: ");
            //WriteArray(alphabetic);
            #endregion

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            #region Reverse
            ////Reverse Metodu
            //Array.Reverse(array);
            //Console.Write("Ters Nümerik Dizi: ");
            //WriteArray(array);

            //Console.WriteLine();

            //Array.Reverse(alphabetic); 
            //Console.Write("Ters Alfabetik Dizi: ");
            //WriteArray(alphabetic);

            #endregion

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            #region IndexOf
            //string[] cities = { "Bursa", "İstanbul", "Ankara", "İzmir" };
            //Console.WriteLine("Şehirler: ");
            //WriteArray(cities);

            //int index = Array.IndexOf(cities, "İstanbul");

            //Console.WriteLine("İstanbul'un indeksi: " + index);
            #endregion

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            #region Copy
            //int[] copiedArray = new int[10];
            //Array.Copy(array, copiedArray, 10);
            //Console.Write("Kopyalanmış Nümerik Dizi: ");
            //WriteArray(copiedArray);

            //char[] copiedChar = new char[10];
            //Array.Copy(alphabetic, copiedChar, 10);
            //Console.Write("Kopyalanmış Alfabetik Dizi: ");
            //WriteArray(copiedChar);
            #endregion

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            #region MAX and MIN
            //int min = array.Min();
            //int max = array.Max();

            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);
            #endregion

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();

            #region Clear
            Array.Clear(array,1,2);
            Console.Write("Silinmiş Dizi: ");
            WriteArray(array);
            #endregion

            Console.ReadKey();
        }

        private static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + " - ");
                }
                else
                {
                    Console.Write(array[i] + "\n");
                }
            }
        }

        private static void WriteArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + " - ");
                }
                else
                {
                    Console.Write(array[i] + "\n");
                }
            }
        }
        private static void WriteArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + " - ");
                }
                else
                {
                    Console.Write(array[i] + "\n");
                }
            }
        }

    }
}
