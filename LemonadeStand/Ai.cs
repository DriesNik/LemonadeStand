using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ai
    {       
        Random r = new Random();        
        Player PlayerEins;
        Weather Day;
        public Ai(Weather day,Player playerEins)
        {
            Day = day;
            PlayerEins = playerEins;
        }

        int buyChance;

        public int ChanceToBuy()
        {
            Thread.Sleep(1);
            buyChance = r.Next(100);
            return buyChance;
        }

        public int DidTheyBuy()
        {
            if (ChanceToBuy() <= PlayerEins.PowerToSell())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
