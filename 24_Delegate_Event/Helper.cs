using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Delegate_Event
{
    delegate void MyHandler();

    static class Helper
    {
        public static MyHandler Hand { get; set; }

        public static void AddMethod(MyHandler myHandler)
        {
            Hand += myHandler;
        }

        public static void Invoke()
        {
            Hand();
        }
    }
}
