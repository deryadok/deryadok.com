namespace _12_Metotlar_New
{
    public static class StaticMethods
    {
        #region Pass by value
        public static void PassValueType(int deger)
        {
            deger = 100;
        }

        public static void PassReferenceType(string deger)
        {
            deger = "Yeni";
        }
        public static void PassObject(object deger)
        {
            deger = "Yeni obje";
        }
        #endregion

        #region REF Metot
        public static void Change(ref int number)
        {
            number = 50;
        }
        #endregion

        #region REF Örnek
        public static void Swap(ref string text1, ref string text2)
        {
            string temp = string.Empty;

            temp = text1;
            text1 = text2;
            text2 = temp;
        }
        #endregion

        #region Array Resize
        public static void ArrayResize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        #endregion

        #region OUT
        public static string GetWordAndFirstLetter(out char letter)
        {
            string quote = "Kendin ol, diğer herkesten zaten çokça var. O.W";
            letter = quote[0];
            return quote;
        }
        #endregion

        #region OUT Örnek
        public static int GetParts(decimal value, out decimal floating)
        {
            int number = (int)value;
            floating = value - number;
            return number;
        }
        #endregion

        #region Custom TryParse
        public static bool TryParse(string value, out int number)
        {
            try
            {
                number = int.Parse(value);
                return true;
            }
            catch
            {
                number = 0;
                return false;
            }
        }
        #endregion

        #region Method Overloading

        public static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static double Toplama(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int Toplama(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public static decimal Toplama(params int[] sayilar)
        {
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam;
        }
        #endregion

        #region Method Overloading
        public static void SendMail(string to, string from, string subject, string message)
        {
            Console.WriteLine($"{to} kişisine {from} kişisinden {subject} konulu bir mail gönderildi");
        }

        public static void SendMail(string[] to, string from, string subject, string message)
        {
            foreach (string item in to)
            {
                Console.WriteLine($"{item} kişisine {from} kişisinden {subject} konulu bir mail gönderildi");
            }
        }
        #endregion

        #region Recursive Metotlar
        public static int Fibonacci(int order)
        {
            if (order == 1)
            {
                return 1;
            }
            else if (order == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(order - 1) + Fibonacci(order - 2);
            }
        }
        #endregion

        #region Recursive Örnek
        public static int Factorial(int number)
        {
            int result;

            if (number == 0)
            {
                result = 1;
            }
            else
            {
                result = number * Factorial(number - 1);
            }

            return result;
        }
        #endregion

        #region Recursive Pascal
        public static int[] Pascal(int row)
        {
            int[] items = new int[row];
            items[0] = 1;
            items[row - 1] = 1;

            if (row > 2)
            {
                int[] prevItems = Pascal(row - 1);
                for (int i = 1; i < prevItems.Length; i++)
                {
                    items[i] = prevItems[i - 1] + prevItems[i];
                }
            }

            return items;
        }
        #endregion
    }
}
