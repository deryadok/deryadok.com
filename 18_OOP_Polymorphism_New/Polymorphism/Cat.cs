using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_Polymorphism_New.Polymorphism
{
    internal class Cat : Animal
    {
        public string StayInside()
        {
            return "I'm staying inside. Purr!";
        }
        public override string MakeNoise()
        {
            return "Purr!";
        }
    }
}
