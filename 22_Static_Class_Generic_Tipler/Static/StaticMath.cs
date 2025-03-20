using System.Collections.Generic;

namespace _22_Static_Class.Static
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
