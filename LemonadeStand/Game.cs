using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Inventory barn;
        Weather day = new Weather();
        Player playerEins;
        public Game()
        {            
            playerEins = new Player(day, barn);
            barn = new Inventory(playerEins);
        }
        public double cupsBought;
        double dollaBils;
        double netProfit;
        int dayCount;
        public void StartGame()
        {
            StartIntro();
            GatherInfo();
            SetFinites();
            playerEins.MoneyProblems();           
            DayByDayLoop();
            ShowFinalProfit();            
        }
        private void DayByDayLoop()
        {
            while (dayCount <= 6)
            {
                cupsBought = 0;
                DisplayDay();
                GenerateSetting();
                Thread.Sleep(500);
                CheckInventory();
                GetRecipe();
                CheckRecipe();
                GenerateClients();
                RunDay();
                MoneyAdding();
                Prof();
                PlusDay();
            }
        }

        private void DisplayDay()
        {
            Console.WriteLine("\n It is Day: " + (dayCount + 1));
        }

        private void PlusDay()
        {
            dayCount++;
        }

        private void CheckRecipe()
        {
            playerEins.GetMaxPitchers();
        }

        public void Prof()
        {
            netProfit = (playerEins.ReturnLoss() + dollaBils);
            Console.WriteLine("Your running profit total is " + netProfit);
        }
           
        private void ShowFinalProfit()
        {
            Prof();
        }
        private void MoneyAdding()
        {
            
            dollaBils = (cupsBought * playerEins.MoneyRecipe());
            Console.WriteLine("you made " + dollaBils + "dollars today");
        }
        private void RunDay()
        {
            Console.WriteLine("this many cups bought");
            Console.WriteLine(cupsBought);
        }
        private void GenerateClients()
        {
            int i;
            
            for (i = 1; i < 100; i++)
            {
                Ai Dude = new Ai(day, playerEins);
                if (playerEins.CheckPitchers() >= 0)
                {
                    switch (Dude.DidTheyBuy())
                    {
                        case 1:
                            UpCup();
                            if ((cupsBought % 12 == 0) && (cupsBought >=1))
                            {
                                playerEins.UsePitcher();
                            }
                            else
                            {
                                break;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    break;
                }
                
            }            
        }
        private void CheckInventory()
        {
            
            Console.WriteLine("You have " + playerEins.ReturnLemon() + " Lemons, " + playerEins.ReturnSugar() +" units of Sugar, " + playerEins.ReturnIce() + " units of Ice");
            Console.WriteLine("Would you like to go to the store?");            
            switch(Console.ReadLine())
            {
                case "yes":
                    barn.StoreUi();
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid answer");
                    CheckInventory();
                    break;
            }

        }
        private void GetRecipe()
        {
            playerEins.MakeRecipe();
        }
        private void GenerateSetting()
        {
            
            Console.WriteLine("The Current Weather Is: "+ day.GrabWeather() + " And the Temperature is: " + day.GrabTemp() + " Degrees");
            day.ShowWeatherBonus();
        }
        private void SetFinites()
        {
            Console.WriteLine("The Predicted Weather for the week is:");
            Console.WriteLine("Sunday: , Monday: , Tuesday: , Wednesday: , Thursday: , Friday: , Saturday: ");
            Console.WriteLine("Your Begining Balance is : " + playerEins.CreateMoney() + "Dollars" );
        }
        public void UpCup()
        {
            cupsBought++;
            

        }
        private void GatherInfo()
        {
            
            playerEins.GrabName();

        }
        private void StartIntro()
        {
            Console.WriteLine("Welcome to LemonadeStand");
            Console.WriteLine("The goal is to make the most profit possible by selling lemonade");
        }
    }
}
