using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalitim_Inheritance_.NonInheritance
{
    public class Dog
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public string Bark()
        {
            return "Woof!";
        }

        public string GoOutside()
        {
            return "I'm going to outside. Woof!";
        }
    }
}
