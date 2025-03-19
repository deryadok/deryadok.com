using System;

namespace _08_JumpingKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            #region break Kullanımı
            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        Console.WriteLine("Döngü sonlandı!");
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region İç içe döngü break kullanımı
            //for (int i = 0; i < 10; i++)
            //{
            //    int j = 6;

            //    while (j < 7)
            //    {
            //        Console.WriteLine("i: " + i);

            //        if (i == 5)
            //        {
            //            Console.WriteLine("j: " + j);
            //            Console.WriteLine("While döngüsü sonlandı");
            //            break;
            //        }

            //        j++;
            //    }
            //}
            #endregion

            #region continue kullanımı
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region return Kullanımı
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i % 2 == 0)
            //    {
            //        return;
            //    }
            //}
            #endregion

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (k == 2)
                        {
                            goto bitir;
                        }
                    }
                }
            }

        bitir:
            Console.WriteLine("k değeri 2'ye eşit");

            Console.ReadKey();
        }
    }
}
