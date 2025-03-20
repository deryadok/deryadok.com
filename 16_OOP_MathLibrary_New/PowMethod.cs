namespace _16_OOP_MathLibrary_New
{
    public class PowMethod
    {
        private int _base;

        private int _pow;

        private int _result;

        public int Base
        {
            set
            {
                _base = value;
            }
            get
            {
                return _base;
            }
        }
        
        public int Pow
        {
            set
            {
                _pow = value;
            }
            get
            {
                return _pow;
            }
        }

        public int Result
        {
            get
            {
                return _result;
            }
            private set
            {
                _result = value;
            }
        }

        private void CalculatePrivateMethod()
        {
            int result = 1;

            for (int i = 1; i <= _pow; i++)
            {
                result = result * _base;
            }

            Result = result;
        }

        protected void CalculateProtectedMethod()
        {
            int result = 1;

            for (int i = 1; i <= _pow; i++)
            {
                result = result * _base;
            }

            Result = result;
        }

        internal void CalculateInternalMethod()
        {
            int result = 1;

            for (int i = 1; i <= _pow; i++)
            {
                result = result * _base;
            }

            Result = result;
        }

        protected internal void CalculateProtectedInternalMethod()
        {
            int result = 1;

            for (int i = 1; i <= _pow; i++)
            {
                result = result * _base;
            }

            Result = result;
        }

        public void CalculatePublicMethod()
        {
            int result = 1;

            for (int i = 1; i <= _pow; i++)
            {
                result = result * _base;
            }

            Result = result;
        }

    }
}
