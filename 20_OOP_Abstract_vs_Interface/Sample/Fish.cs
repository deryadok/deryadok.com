using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_Abstract_vs_Interface.Sample
{
    internal class Fish : ISwim
    {
        public string Dive()
        {
            return "Balık daldı!";
        }

        public string GetOut()
        {
            return "Balık çıktı!";
        }

        public string Swim()
        {
            return "Balık yüzdü!";
        }
    }
}
