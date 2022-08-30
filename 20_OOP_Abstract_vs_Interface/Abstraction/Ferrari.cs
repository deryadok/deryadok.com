using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Abstract_vs_Interface.Abstraction
{
    internal class Ferrari : Car
    {
        public override string MaximumSpeed()
        {
            return "Ferrari'nin maximum hızı: 300";
        }
    }
}
