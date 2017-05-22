using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class MovingCircle : INotifyPropertyChanged
    {
        private double x;
        private double y; 
        
        
        static int count = 0;
        public MovingCircle(double Radius, double Speed)
        {
            VX = Speed;
            VY = 0;
            Y = 100;
            X = 100 + count * 50;
            count++;
            Energy = 10;
        }
        public readonly double Radius;
        public readonly double Speed;

        protected double VX;
        protected double VY;
        protected int Energy { get; set; }
        public bool IsDead { get { return Energy <= 0; } }

        public double X
        {
            get { return x; }
            protected set
            {
                x = value;
                OnPropertyChanged("X");
            }
        }
        public double Y
        {
            get { return y; }
            protected set
            {
                y = value;
                OnPropertyChanged("Y");
            }
        }
        public void Move(double deltaT)
        {
            X += VX * deltaT;
            Y += VY * deltaT;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
