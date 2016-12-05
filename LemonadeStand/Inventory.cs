﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        Random r = new Random();
        Player PlayerEins;
        public Inventory(Player playerEins)
        {
            PlayerEins = playerEins;
        }      
       public void StoreUi()
        {
            Intro();
            StoreFront();
        }
        public void Intro()
        {
            Console.WriteLine("Welcoem to the Store");
                     
        }
        public void StoreFront()
        {
            Console.WriteLine("What would you like to buy? Lemons, Sugar, Ice, Nothing? ");
            switch (Console.ReadLine())
            {
                case "lemons":
                    BuyLemons();
                    break;
                case "sugar":
                    BuySugar();
                    break;
                case "ice":
                    BuyIce();
                    break;
                case "nothing":
                    break;
                default:
                    StoreFront();
                    break;
            }
        }
        public void BuyLemons()
        {
            Console.WriteLine("Lemons are 75 cents");
            Console.WriteLine("How Many Would You Like?");
            int d = (int.Parse(Console.ReadLine()));
            int i;
            for (i = 0; i < d; i++)
            {
                if (PlayerEins.GetMoney() > 0.75)
                {
                    PlayerEins.AddLemons();
                    PlayerEins.MoneyForLemons();
                }
                else
                {
                    Console.WriteLine("You have bought " + i);
                    Console.WriteLine("You cant afford any more");
                    break;
                }
            }
            StoreFront();
        }
        public void BuySugar()
        {
            Console.WriteLine("Sugar Is 35 cents");
            Console.WriteLine("How Many Would You Like?");
            int d = (int.Parse(Console.ReadLine()));
            int i;
            for (i = 0; i < d; i++)
            {
                if (PlayerEins.GetMoney() > 0.35)
                {
                    PlayerEins.AddSugar();
                    PlayerEins.MoneyForSugar();
                }
                else
                {
                    Console.WriteLine("You have bought " + i);
                    Console.WriteLine("You cant afford any more");
                    break;
                }
            }
            StoreFront();
        }
        public void BuyIce()
        {
            Console.WriteLine("Ice is 10 cents");
            Console.WriteLine("How Many Would You Like?");
            int d = (int.Parse(Console.ReadLine()));
            int i;
            for (i = 0; i < d; i++)
            {
                if (PlayerEins.GetMoney() > 0.10)
                {
                    PlayerEins.AddIce();
                    PlayerEins.MoneyForIce();
                }
                else
                {
                    Console.WriteLine("You have bought " + i);
                    Console.WriteLine("You cant afford any more");
                    break;
                }
            }
            StoreFront();
        }
    }
}