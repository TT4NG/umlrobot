using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRendition
{
    class Drone: Robot
    {
        public void drone()
        {
            Console.WriteLine("You selected Drone!");
            Console.WriteLine("Time to spy!");
            Console.ReadKey();
            surveillance();

        }
        public void chargePower()
        {
            Console.WriteLine("drone is dead time to recharge");
            powerlevel += 100;
            Console.WriteLine("drone is back at : " + powerlevel);
            Console.ReadKey();
        }
        public void surveillance()
        {
            while (powerlevel > 0)
            {
                Console.WriteLine("drone " + mobility + " through the skies looking for suspicious activity \n looks like we found something suspicious!");
                Console.ReadKey();
                takePictures();
            }
            chargePower();
        }
        public void takePictures()
        {
            Console.WriteLine("you snap some photos!!");
            powerlevel -= 20;
            Console.ReadKey();
            surveillance();
        }

    }
}
