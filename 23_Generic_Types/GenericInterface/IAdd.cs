using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic_Types.GenericInterface
{
    internal interface IAdd<T>
    {
        T Add(T param1, T param2);
    }
}
