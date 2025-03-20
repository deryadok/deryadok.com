namespace _20_OOP_Abstract_vs_Interface.Sample
{
    internal class Plane : IFly
    {
        public string Fly()
        {
            return "Uçak uçtu!";
        }

        public string Settle()
        {
            return "Uçak kondu!";
        }
    }
}
