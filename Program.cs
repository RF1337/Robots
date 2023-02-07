using System;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {                       //Colour, microchip, wifi, bc, wheels, soap container
            Robot robot = new Robot("white", false, false, 255, 5, 2.7f);
            Robot cleaningRobot = new Robot("green", false, false, 0, 5, 2.7f);
        }
    }
}
