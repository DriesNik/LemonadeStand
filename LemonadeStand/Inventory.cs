using System;
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
            Console.WriteLine("Welcome to the Store");
                     
        }
        public void StoreFront()
        {
            Console.WriteLine("What would you like to buy? Lemons, Sugar, Ice, or Nothing?");
            switch (Console.ReadLine().ToLower())
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
                    Console.WriteLine("Please enter one of the options");
                    StoreFront();
                    break;
            }
        }
        public void BuyLemons()
        {
            try
            {
                Console.WriteLine("Lemons are 20 cents");
                Console.WriteLine("How many would you like?");

                int d = (int.Parse(Console.ReadLine()));

                int i;
                for (i = 0; i < d; i++)
                {
                    if (PlayerEins.GetMoney() > 0.20)
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
                Console.WriteLine("Your current balance is : " + PlayerEins.GetMoney());
                StoreFront();
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Invalid Answer");
                BuyLemons();
            }
        }
        public void BuySugar()
        {
            try
            {
                Console.WriteLine("Sugar Is 15 cents per unit");
                Console.WriteLine("How many would you like?");
                int d = (int.Parse(Console.ReadLine()));
                int i;
                for (i = 0; i < d; i++)
                {
                    if (PlayerEins.GetMoney() > 0.15)
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
                Console.WriteLine("Your current balance is : " + PlayerEins.GetMoney());
                StoreFront();
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Invalid Answer");
                BuySugar();
            }
        }
        public void BuyIce()
        {
            try
            {
                Console.WriteLine("Ice is 10 cents per unit");
                Console.WriteLine("How many would you like?");
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
                Console.WriteLine("Your current balance is : " + PlayerEins.GetMoney());
                StoreFront();
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Invalid Answer");
                BuyIce();
            }
        }
    }
}
