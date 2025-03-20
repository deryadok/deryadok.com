namespace _23_Generic_Types.GenericMethod
{
    class Mail<T>
    {
        public string From { get; set; }
        public string To { get; set; }

        public T Data { get; set; }

        public bool Send()
        {
            return true;
        }
    }

    class Invoice { }
}
