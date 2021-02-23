using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Golf
{
    class Swing
    {
        //private int distance;
        public const double gravity = 9.8;
        public int swingID { get; set; }
        public int angle { get; set; }
        public int velocity;
        public int distance;
 
        public Swing(int angle, int velocity)
        {
            this.angle = angle;
            this.velocity = velocity;
        }

       public double angleInRadians 
        {
            get { return ((Math.PI / 180) * angle); }
        
        }

        public int Distance
        {
            get => (int)(distance = (int)(Math.Pow(velocity, 2) / gravity * Math.Sin(2 * angleInRadians)));
            set => distance = value;
        }
    }
}
