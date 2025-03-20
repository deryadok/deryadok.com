namespace _17_OOP_Kalitim_Inheritance__New.Constructor
{
    public class Car : Vehicle
    {
        //public Car()
        //{
        //    Console.WriteLine("Car constructor çalıştı!");
        //}

        //public Car(string message)
        //{
        //    Console.WriteLine(message);
        //}

        public Car() : base("Hello vehicle!")
        {
            Console.WriteLine("Car constructor çalıştı!");
        }

        ~Car()
        {
            Console.WriteLine("Car objesi yok oldu!");
        }
    }
}
