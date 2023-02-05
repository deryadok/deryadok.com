using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic_Types.GenericMethod
{
    class Mail<T>
    {
        public string From { get; set; }
        public string To { get; set; }

        public T Data { get; set; }

        public bool Send()
        {
            return true;
        }
    }

    class Invoice { }
}
