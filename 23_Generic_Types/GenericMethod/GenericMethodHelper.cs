using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Generic_Types.GenericMethod
{
    internal static class GenericMethodHelper
    {
        public static void FindMax<T>(T param1, T param2)
        {
            //if (param1 > param2)
            //{

            //}

            if (param1.ToString().CompareTo(param2.ToString()) == 1)
            {
                Console.WriteLine(param1.ToString());
            }
            else
            {
                Console.WriteLine(param2.ToString());
            }
        }

        public static bool SendMail<T>(SystemMembers member, T data)
        {
            bool result = false;
            switch (member)
            {
                case SystemMembers.Admin:
                    result = new Mail<string>() { From = "site@site.com", To = "admin@site.com", Data = "Yeni üye var" }.Send();
                    break;
                case SystemMembers.Developer:
                    result = new Mail<Exception>() { From = "site@site.com", To = "developer@site.com", Data = new Exception() }.Send();
                    break;
                case SystemMembers.Customer:
                    result = new Mail<Invoice> { From = "site@site.com", To = "cust@gmail.com", Data = new Invoice() }.Send();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
