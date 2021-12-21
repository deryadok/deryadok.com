using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OOP_Kalitim_Inheritance_.Constructor
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle constructor çalıştı!");
        }

        public Vehicle(string message)
        {
            Console.WriteLine(message);
        }
    }
}
