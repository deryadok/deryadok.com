using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Static_Class.NonStatic
{
    internal class MathClass
    {
        public static double PI = 3.14;

        public MathClass()
        {
            PI = 3.1415;
        }

        static MathClass()
        {
            PI = 3.141592;
        }

        public void ChangethePitoInt()
        {
            PI = 3;
        }
    }
}
