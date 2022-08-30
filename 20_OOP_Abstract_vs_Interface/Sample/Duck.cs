using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Abstract_vs_Interface.Sample
{
    internal class Duck : ISwim, IFly
    {
        public string Dive()
        {
            return "Ördek daldı!";
        }

        public string Fly()
        {
            return "Ördek uçtu!";
        }

        public string GetOut()
        {
            return "Ördek çıktı!";
        }

        public string Settle()
        {
            return "Ördek kondu!";
        }

        public string Swim()
        {
            return "Ördek yüzdü!";
        }
    }
}
