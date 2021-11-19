using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalitim_Inheritance_.Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public string MakeNoise(string noise)
        {
            return noise;
        }
    }
}
