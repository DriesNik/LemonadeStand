using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        string name;
        public string GrabName()
        {
            Console.WriteLine("Please enter Your Name");
            name = Console.ReadLine();
            return name;
        }
    }
}
