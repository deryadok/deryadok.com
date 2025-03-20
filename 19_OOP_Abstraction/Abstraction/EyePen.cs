namespace _19_OOP_Abstraction.Abstraction
{
    internal class EyePen : Pen
    {
        public bool DoesHaveBrush { get; set; }

        public bool IsWaterBased { get; set; }

        public int Thickness { get; set; }

        //Kalemin kapağını açmak için kullanılan fonksiyon
        public void OpenCap()
        {

        }

        public override string Write()
        {
            return "I am a EyePen";
        }

    } 
}
