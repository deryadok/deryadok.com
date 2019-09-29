using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForDonguYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i -= 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; ;)
            //{
            //    Console.WriteLine("Hello World!");
            //}

            //for (; false;)
            //{

            //}

            //int j;

            //for (; ; j += 3)
            //{

            //}

            //for (; j < 5; j++)
            //{

            //}

            //for (j = 10; ; j--)
            //{

            //}

            //for (j = 30; j > 25;)
            //{

            //}

            Console.Write("Satýr sayýsý : ");
            int satir = int.Parse(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < satir - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < (2 * i - 1); j++)
                {
                    if (i == satir - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i > 0)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
