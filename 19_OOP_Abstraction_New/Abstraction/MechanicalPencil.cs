namespace _19_OOP_Abstraction_New.Abstraction
{
    internal class MechanicalPencil : Pen
    {
        public decimal LineWidth { get; set; }

        public override string Write()
        {
            return "I am a MechanicalPencil";
        }
    }
}
