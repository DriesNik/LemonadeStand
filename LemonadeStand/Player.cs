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
        int beginMoney;
        public string GrabName()
        {
            Console.WriteLine("Please enter Your Name");
            name = Console.ReadLine();
            return name;
        }
        public int CreateMoney()
        {
            Random r = new Random();
            beginMoney = r.Next(20, 100);
            return beginMoney;
        }
    }
}
