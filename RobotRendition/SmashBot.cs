using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRendition
{
    class SmashBot:Robot
    {
        public void smashBot()
        {
            Console.WriteLine("SmashBot selected!");
            Console.WriteLine("we now instance the WallE");
            Console.ReadKey();
            WallE wall = new WallE();
            wall.wallE();
        }
        public void smashStuff()
        {
            while (powerlevel > 0)
            {
                Console.WriteLine("We smash the bots");
                Console.ReadKey();
                powerlevel -= 25;
            }
            Console.WriteLine("out of power sleep mode");
            Console.ReadKey();
        }
        public void chargePower()
        {
            Console.WriteLine(powerlevel + " is current power level, lets recharge");
            powerlevel += 100;
            Console.ReadKey();
            Console.WriteLine("charge is complete, battery power is: " + powerlevel + "%");
            Console.ReadKey();
        }
    }
}
