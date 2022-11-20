using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Static_Class_Generic_Tipler.Static
{
    internal static class StaticMath
    {
        public static string NullString = null;
        public static double Pi = 3.14;

        public static int Addition(List<int> numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public static int Multiplication(List<int> numbers)
        {
            int result = 1;
            foreach (int item in numbers)
            {
                result *= item;
            }
            return result;
        }

        public static void ChangethePitoInt()
        {
            Pi = 3;
        }
    }
}
