namespace _19_OOP_Abstraction.NestedAbstraction
{
    internal class ClassicalGuitar : Guitar
    {
        public override int StringCount { get => 6; }

        public override string PlaySound()
        {
            return "I am a Classic Guitar!";
        }
    }
}
