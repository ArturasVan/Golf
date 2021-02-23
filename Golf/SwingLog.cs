using System;
using System.Collections.Generic;
using System.Text;

namespace Golf
{
    class SwingLog
    {
        public int swingID { get; set; }
        public int angle { get; set; }
        public int velocity { get; set; }
        public int distance { get; set; }



        public void ReturnLogElement(int swingID)
        {
            Console.WriteLine("Your {0} swing parameters:\n" +
                              "Angle: {1}\n" +
                              "Velocity: {2}\n" +
                              "Distance: {3}", swingID, angle, velocity, distance);
        }
    }
}
