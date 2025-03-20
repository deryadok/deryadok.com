namespace _20_OOP_Abstract_vs_Interface_New.Sample
{
    internal class Submarine : ISwim
    {
        public string Dive()
        {
            return "Denizaltı daldı!";
        }

        public string GetOut()
        {
            return "Denizaltı çıktı!";
        }

        public string Swim()
        {
            return "Denizaltı yüzdü!";
        }
    }
}
