using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Robot
    {
        //Standard
        public Robot(string colour, string microchip, byte wheels)
        {
            colour = "white";
            Console.WriteLine(colour + " " + microchip);
        }

        //With wifi
        public Robot(string colour, string microchip, bool hasWifi, byte wheels) : this(colour, microchip, wheels)
        {
            hasWifi = true;
            Console.WriteLine(colour + " " + microchip + " " + hasWifi + " " + wheels);
        }

        //With battery
        public Robot(string colour, string microchip, byte batteryCapacity, byte wheels)
        {
            colour = "white";
            Console.WriteLine(colour + " " + microchip + " " + batteryCapacity + " " + wheels);
        }

        //Cleaning robot
        public Robot(string colour, string microchip, float soapContainer, byte wheels) 
        {
            soapContainer = 2.7f;
            Console.WriteLine(colour + " " + microchip + " " + soapContainer + " " + wheels);
        }

        //Small robot
        public Robot(string colour, string microchip) 
        {
            colour = "white";
            Console.WriteLine(colour + " " + microchip);
        }
    }
}
