using System.Collections.Generic;

namespace _23_Generic_Types.GenericConstraint
{
    internal class MyGenericClass<T>
        //where T : struct // Value Type Constraint
        //where T : class // Reference Type Constraint
        //where T : new() // Default Constructor Constraint
        //where T : MyClass, new()
        where T : IEnumerable<T>

    {
    }

    internal class MyGenericClass<T, K>
        where T : IEnumerable<T>
        where K : class
    {
    }
}
