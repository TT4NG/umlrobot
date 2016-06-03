using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRendition
{
    class Robot
    {
        public string function = "autonomous";
        public string mobility = "moves";
        public int powerlevel = 100;
        public string recharge = "recharging";
        public string sensors = "scanning";
        public void robot()
        {
            int choice;
            Console.WriteLine("Welcome to the world of Robots!");
            Console.WriteLine("Select your bot! \n 1 - BattleBot \n 2 - SmashBot \n 3 - Drone \n 4 - WallE \n 5 - Roomba");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice <= 0 || choice >= 6)
            {
                Console.WriteLine("invalid selection");
                robot();
            }
            else if (choice == 1)
            {
                BattleBot bat = new BattleBot();
                bat.battleBot();
            }
            else if (choice == 2)
            {
                SmashBot sma = new SmashBot();
                sma.smashBot();
            }
            else if (choice == 3)
            {
                Drone d = new Drone();
                d.drone();
            }
            else if (choice == 4)
            {
                WallE w = new WallE();
                w.wallE();
            }
            else if (choice == 5)
            {
                Roomba r = new Roomba();
                r.roomba();
            }
        }
    }
}
