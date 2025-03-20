namespace _23_Generic_Types.GenericInterface
{
    internal class StringAdd : IAdd<string>
    {
        public string Add(string param1, string param2)
        {
            return param1 + " " + param2;
        }
    }
}
