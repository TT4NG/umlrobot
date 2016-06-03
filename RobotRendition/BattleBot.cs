using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRendition
{
    class BattleBot: Robot
    {
        int weapons;
        public void battleBot()
        {
            Console.WriteLine("you've selected battlebot, its time to clash!");
            Console.WriteLine("the enemy bot comes at you, quick get a weapon!");
            useWeapon();
            attack();

        }
        public void attack()
        {
            while (powerlevel > 0)
            {
                Console.WriteLine("attack!");
                Console.ReadLine();
                powerlevel -= 15;
            }
            Console.WriteLine("out of power but we took him out!");
            Console.ReadKey();
        }
        public void useWeapon()
        {
            Console.WriteLine("select a weapon: \n 1 - sword \n 2 - mace");
            int.TryParse(Console.ReadLine(), out weapons);
            if (weapons <= 0 || weapons >= 3)
            {
                Console.WriteLine("invalid choice");
                useWeapon();
            }
            else if (weapons == 1)
            {
                Console.WriteLine("you chose the sword");
                Console.ReadKey();
            }
            else if (weapons == 2)
            {
                Console.WriteLine("you choise the mace");
                Console.ReadKey();
            }
        }
    }
}
