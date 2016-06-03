using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRendition
{
    class Roomba:Robot
    {
        public void roomba()
        {
            Console.WriteLine("You Chose Roomba!!!");
            Console.ReadKey();
            cleanFloors();
            chargePower();
        }
        public void chargePower()
        {
            Console.WriteLine(powerlevel + " is current power level, lets recharge");
            powerlevel += 100;
            Console.WriteLine("charge is complete, battery power is: " + powerlevel + "%");
            Console.ReadKey();

        }
        public void cleanFloors()
        {
            Console.WriteLine("clean floors protocol initiated");
            powerlevel -= 100;
        }
    }
}
