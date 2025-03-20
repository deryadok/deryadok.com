namespace _19_OOP_Abstraction.Abstraction
{
    internal abstract class Pen
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public abstract string Write();
        public virtual string Erase()
        {
            return "Erase";
        }
    }
}
