using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Abstract_vs_Interface.Sample
{
    internal class Submarine : ISwim
    {
        public string Dive()
        {
            return "Denizaltı daldı!";
        }

        public string GetOut()
        {
            return "Denizaltı çıktı!";
        }

        public string Swim()
        {
            return "Denizaltı yüzdü!";
        }
    }
}
