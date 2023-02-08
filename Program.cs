using System;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {

            Robot standardRobot = new Robot("black", "QT8339", 3);
            Robot wifiRobot = new Robot("yellow", "QT8339", false, 2);
            Robot batteryRobot = new Robot("black", "QT8339", 200, 4);
            Robot cleaningRobot = new Robot("black", "QT8339", 1.7f, 5);
            Robot smallRobot = new Robot("black", "QT8339");




        }
    }
}
