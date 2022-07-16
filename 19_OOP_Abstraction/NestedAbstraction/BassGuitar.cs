using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Abstraction.NestedAbstraction
{
    internal class BassGuitar : Guitar
    {
        public override int StringCount => 4;

        public override string PlaySound()
        {
            return "I am a Bass Guitar!";
        }
    }
}
