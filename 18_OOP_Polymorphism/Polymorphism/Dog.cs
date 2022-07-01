using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_Polymorphism.Polymorphism
{
    internal class Dog : Animal
    {
        public string GoOutside()
        {
            return "I'm going to outside. Woof!";
        }

        public override string MakeNoise()
        {
            return "Woof!";
        }
    }
}
