using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic_Types.MultipleGenericType
{
    internal class MultipleGenericType<T,U,K>
    {
        public T TProperty { get; set; }
        public U UProperty { get; set; }
        public K KProperty { get; set; }
    }
}
