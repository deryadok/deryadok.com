using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Delegate_Event
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        Car myCar = new Car();

        private void timer1_Tick(object sender, EventArgs e)
        {
            myCar.SpeedUp();
            lblInfo.Text = $"{myCar.Brand} arabası {myCar.Speed} ile gidiyor.";
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            myCar.Brand = "Dacia";
            myCar.Speed = 50;
            myCar.MaxSpeed = 90;

            myCar.reachedMaxSpeedEvent += myCarHasReacedMaxSpeed;
        }

        void myCarHasReacedMaxSpeed(object sender, EventArgs e)
        {
            Car currentCar = sender as Car;
            CarEventArgs args = e as CarEventArgs;
            timer1.Stop();
            MessageBox.Show($"{currentCar.Brand} arabası aşırı hız yaptı. Hız: {args.Speed}");
        }
    }
}
