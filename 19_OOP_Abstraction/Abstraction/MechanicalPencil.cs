using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Abstraction.Abstraction
{
    internal class MechanicalPencil : Pen
    {
        public decimal LineWidth { get; set; }

        public override string Write()
        {
            return "I am a MechanicalPencil";
        }
    }
}
