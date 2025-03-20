namespace _17_OOP_Kalitim_Inheritance__New.NonInheritance
{
    public class Dog
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }

        public string Bark()
        {
            return "Woof!";
        }

        public string GoOutside()
        {
            return "I'm going to outside. Woof!";
        }
    }
}
