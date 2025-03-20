namespace _18_OOP_Polymorphism.Polymorphism
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public virtual string MakeNoise()
        {
            return "Animal";
        }
    }
}
