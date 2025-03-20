namespace _19_OOP_Abstraction.NestedAbstraction
{
    internal class BassGuitar : Guitar
    {
        public override int StringCount => 4;

        public override string PlaySound()
        {
            return "I am a Bass Guitar!";
        }
    }
}
