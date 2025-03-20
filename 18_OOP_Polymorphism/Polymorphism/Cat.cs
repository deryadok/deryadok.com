namespace _18_OOP_Polymorphism.Polymorphism
{
    internal class Cat : Animal
    {
        public string StayInside()
        {
            return "I'm staying inside. Purr!";
        }
        public override string MakeNoise()
        {
            return "Purr!";
        }
    }
}
