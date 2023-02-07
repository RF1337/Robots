using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Robot
    {
        //Creating the different variables for the robots and giving some a default value
        String colour = "white";
        bool microchip;
        bool wifi;
        byte batteryCapacity = 255;
        byte wheels = 0;
        float soapContainer = 2.7f;

        //Creating our constructor
        public Robot(String colour, bool microchip, bool wifi, byte batteryCapacity, byte wheels, float soapContainer)
        {
            this.colour = colour;
            this.microchip = microchip;
            this.wifi = wifi;
            this.batteryCapacity = batteryCapacity;
            this.wheels = wheels;
            this.soapContainer = soapContainer;
        }
    }
}
