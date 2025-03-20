namespace _19_OOP_Abstraction_New.Abstraction
{
    internal class BoardPen : Pen
    {
        public bool CanRefill { get; set; }

        public override string Write()
        {
            return "I am a BoardPen!";
        }
    }
}
