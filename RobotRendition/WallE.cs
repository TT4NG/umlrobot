using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRendition
{
    class WallE:Robot
    {
        string manipulator;
        public void wallE()
        {
            Console.WriteLine("Wall-Eeeeeee Selected!");
            Console.ReadKey();
            collectTrash();
        }
        public void collectTrash()
        {
            Console.WriteLine("Lets make this planet nicer and collect trash!");
            Console.ReadKey();
            powerlevel -= 25;
            compactTrash();
        }
        public void compactTrash()
        {
            Console.WriteLine("Good job collecting time to compact it into towers!");
            Console.ReadKey();
            powerlevel -= 25;
            stackTrash();
        }
        public void rechargePower()
        {
            Console.WriteLine(powerlevel + " is current power %");
            powerlevel += 100;
            Console.WriteLine("power re-established!");
            Console.ReadKey();
        }
        public void stackTrash()
        {
            Console.WriteLine("We made a fine recycled tower today Great Job!");
            Console.ReadKey();
            powerlevel -= 50;
            rechargePower();
        }
    }
}
