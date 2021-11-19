using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalitim_Inheritance_.NonInheritance
{
    public class Cat
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public string Purr()
        {
            return "Meow!";
        }

        public string StayInside()
        {
            return "I'm staying inside. Purr!";
        }
    }
}
