using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic_Types.GenericInterface
{
    internal class IntegerAdd : IAdd<int>
    {
        public int Add(int param1, int param2)
        {
            return param2 + param1;
        }
    }
}
