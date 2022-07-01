using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_Polymorphism.Polymorphism
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public virtual string MakeNoise()
        {
            return "Animal";
        }
    }
}
