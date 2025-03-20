namespace _23_Generic_Types_New.GenericInheritance
{
    internal class FirstClass<T>
    {
        public void GetType(T param)
        {
            Console.WriteLine("Type : " + param.GetType().Name);
            Console.WriteLine("BaseType : "  + param.GetType().BaseType.Name);
            Console.WriteLine();
        }
    }

    internal class SecondClass : FirstClass<int>
    {

    }

    internal class ThirdClass<U> : FirstClass<U>
    {

    }
}
