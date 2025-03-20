namespace _17_OOP_Kalitim_Inheritance__New.NonInheritance
{
    public class Cat
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public string Purr()
        {
            return "Meow!";
        }

        public string StayInside()
        {
            return "I'm staying inside. Purr!";
        }
    }
}
