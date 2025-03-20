using System;

namespace _15_OOP_Kapsulleme_Encapsulation__New
{
    class Person
    {
        #region 1. Yöntem
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        #endregion

        #region 2. Yöntem
        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        #endregion

        #region 3. Yöntem
        public string EMail { get; set; } //prop yazıp iki kere taba bastığınızda otomatik olarak eklenir.
        #endregion
    }
}
