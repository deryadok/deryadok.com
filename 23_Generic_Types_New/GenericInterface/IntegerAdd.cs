namespace _23_Generic_Types_New.GenericInterface
{
    internal class IntegerAdd : IAdd<int>
    {
        public int Add(int param1, int param2)
        {
            return param2 + param1;
        }
    }
}
