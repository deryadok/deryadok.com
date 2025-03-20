namespace _24_Delegate_Event_New
{
    delegate void MyHandler();

    static class Helper
    {
        public static MyHandler Handler { get; set; }

        public static void AddMethod(MyHandler myHandler)
        {
            Handler += myHandler;
        }

        public static void RemoveMethod(MyHandler myHandler)
        {
            Handler -= myHandler;
        }

        public static void Invoke()
        {
            Handler();
        }
    }
}
