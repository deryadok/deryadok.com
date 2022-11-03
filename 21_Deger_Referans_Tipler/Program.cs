using _21_Deger_Referans_Tipler.DegerTipler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Deger_Referans_Tipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Coordinate coordinate = new Coordinate(15, 20);
            //int result = coordinate.Sum();
            //Console.WriteLine(result);

            //int value = (int)Days.Friday;
            //Console.WriteLine(Days.Friday);
            //Console.WriteLine(value.ToString());

            //List<int> values = new List<int>();
            //Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    values.Add(random.Next(0, 10));
            //}

            //Console.WriteLine("Listeyi sıralamak için lütfen seçim yapın:");
            //Console.WriteLine("1 - Düz");
            //Console.WriteLine("2 - Ters");
            //Console.WriteLine("3 - Büyükten Küçüğe");
            //Console.WriteLine("4 - Küçükten Büyüğe");
            //string value = Console.ReadLine();
            //OrderChoice orderChoice = (OrderChoice)int.Parse(value);
            //WriteList(orderChoice, values);

            //string[] jobs = { "Developer", "Designer", "Product Owner" };
            //string[] jobs2 = { "Engineer", "Analyst" };
            //Console.WriteLine("Before:");
            //Console.WriteLine("jobs[0] " + jobs[0]);
            //Console.WriteLine("jobs2[0] " + jobs2[0]);
            //jobs2 = jobs;
            //Console.WriteLine("After:");
            //Console.WriteLine("jobs[0] " + jobs[0]);
            //Console.WriteLine("jobs2[0] " + jobs2[0]);
            //jobs[0] = "Dev";
            //Console.WriteLine("jobs2[0] " + jobs2[0]);

            string value = "Hello World!";
            value.Replace("World", "Internet");
            Console.WriteLine(value);
            value = value.Replace("World", "Internet");
            Console.WriteLine(value);

            Console.ReadLine();
        }

        static void WriteList(OrderChoice orderChoice, List<int> list)
        {
            switch (orderChoice)
            {
                case OrderChoice.Straight:
                    break;
                case OrderChoice.Reverse:
                    list.Reverse();
                    break;
                case OrderChoice.BigToSmall:
                    list.Sort();
                    list.Reverse();
                    break;
                case OrderChoice.SmallToBig:
                    list.Sort();
                    break;
                default:
                    break;
            }
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
