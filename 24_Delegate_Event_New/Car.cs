namespace _24_Delegate_Event_New
{
    delegate void MyEventHandler(Car sender, CarEventArgs e);
    internal class Car
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }

        public event MyEventHandler reachedMaxSpeedEvent;

        public void SpeedUp()
        {
            Speed += 5;
            if (Speed >= MaxSpeed)
            {
                if (reachedMaxSpeedEvent != null)
                {
                    CarEventArgs e = new CarEventArgs();
                    e.Speed = MaxSpeed;
                    reachedMaxSpeedEvent(this, e);
                }
            }
        }
    }

    class CarEventArgs : EventArgs
    {
        public int Speed { get; set; }
    }
}
