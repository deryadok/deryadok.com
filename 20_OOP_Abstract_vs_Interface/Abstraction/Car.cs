namespace _20_OOP_Abstract_vs_Interface.Abstraction
{
    abstract class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public abstract string MaximumSpeed();
    }
}
