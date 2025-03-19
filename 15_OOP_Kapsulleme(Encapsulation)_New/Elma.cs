using System;

namespace _15_OOP_Kapsulleme_Encapsulation_New
{
    class Elma
    {
        decimal _agirlik;
        decimal _hacim;

        public void SetAgirlik(decimal agirlik)
        {
            if (agirlik > 100 && agirlik < 500)
            {
                _agirlik = agirlik;
            }
            else
            {
                Console.WriteLine("Ağırlık değeri 100 - 500 aralığında olmalıdır");
            }
        }

        public decimal GetAgirlik()
        {
            return _agirlik;
        }

        public void SetHacim(decimal hacim)
        {
            if (hacim > 5 && hacim < 20)
            {
                _hacim = hacim;
            }
            else
            {
                Console.WriteLine("Hacim değeri 5 - 20 aralığında olmalıdır");
            }
        }

        public void GetHacim(string sifre)
        {
            if (sifre == "1234")
            {
                Console.WriteLine("Hacim: " + _hacim.ToString());
            }

            Console.WriteLine("Bu veriyi görme yetkiniz yok");
        }

    }
}
