namespace _20_OOP_Abstract_vs_Interface_New.Interface
{
    internal interface IMath
    {
        int Addition(int num1, int num2);
        int Subtraction(int num1, int num2);
        int Multiplication(int num1, int num2);
        int Division(int num1, int num2);
        string Name { get; }
    }
}
