using System;
using System.Collections.Generic;

namespace Golf
{
    class Program
    {
        static void Main(string[] args)
        {
            var swingList = new List<SwingLog>(); //declaring variables
            int cup = 1000;
            int count = 0;

            Console.WriteLine("Welcome to ___====GOLF 2020====____ simulator\n\n" +
                "You will have 10 tries to put your ball to cup\n" +
                "Every round you will need to provide *Swing angle* and *Swing velocity*\n" +
                "Distance to cup is 1000\n" +
                "to start game pres any key and enter"
                );
            Console.ReadKey();

            while (cup != 0) //main while loop for game logics
            {
                Console.Clear();
                Console.WriteLine("You have made {0} swings, distance left for cup {1}", count, cup);
                Console.WriteLine("Please enter your {0} swing angle", count + 1); //testing if angle value is number if not returning default value
                string angle1 = Console.ReadLine();
                int numAngle;
                int number;
                if(int.TryParse(angle1, out number))
                {
                    numAngle = number;
                }
                else
                {
                    numAngle = 0;
                    Console.WriteLine("Angle entered value vas not number. 0 set as default angle.");
                }

                Console.WriteLine("Please enter your {0} swing velocity", count + 1); //testing if velocity value is number if not returning default value
                string velocity1 = Console.ReadLine();
                int numVelocity;

                if (int.TryParse(velocity1, out number))
                {
                    numVelocity = number;
                }
                else
                {
                    numVelocity = 0;
                    Console.WriteLine("Entered Velocity value vas not number. 0 set as default velocity.");
                }

                Swing first1 = new Swing(numAngle, numVelocity); //creating swing instance

                swingList.Add(new SwingLog       //adding data to log
                {
                    swingID = count,
                    angle = numAngle,
                    velocity = numVelocity,
                    distance = first1.Distance
                });

                count += 1;
                cup -= first1.Distance;
                
                if (cup < 0)          //If ball gets over cup changing distance to positive number
                {
                    cup *= -1; 
                }else if (cup > 1000) 
                {
                    throw new GolfExeption ("/* You made your swing to strong, that's not possible for a human */"); 
                }
                if (count > 10)
                {
                    throw new GolfExeption("/* You have used all swings for this game. */");
                }
                Console.ReadKey();

            }
            //Printing out swings log
            Console.WriteLine("You have made it!!!\n");
            foreach ( var swing in swingList)
            {

                Console.WriteLine(ReturnLogElement(swing));
                Console.WriteLine("Your {0} swing parameters:\n" +
                              "Angle: {1}\n" +
                              "Velocity: {2}\n" +
                              "Distance: {3}", swing.swingID + 1, swing.angle, swing.velocity, swing.distance);
            }
            Console.ReadKey();
        }
    }
}
