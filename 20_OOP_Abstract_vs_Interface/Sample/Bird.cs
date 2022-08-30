using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Abstract_vs_Interface.Sample
{
    internal class Bird : IFly
    {
        public string Fly()
        {
            return "Kuş uçtu!";
        }

        public string Settle()
        {
            return "Kuş kondu!";
        }
    }
}
