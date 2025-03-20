namespace _20_OOP_Abstract_vs_Interface.Interface
{
    internal class MathLib : IMath
    {
        public string Name => "Matematik Kütüphanesi";

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Division(int num1, int num2)
        {
            return (num1 / num2);
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
