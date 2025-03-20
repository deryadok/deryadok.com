namespace _18_OOP_Polymorphism.Polymorphism
{
    internal class Dog : Animal
    {
        public string GoOutside()
        {
            return "I'm going to outside. Woof!";
        }

        public override string MakeNoise()
        {
            return "Woof!";
        }
    }
}
