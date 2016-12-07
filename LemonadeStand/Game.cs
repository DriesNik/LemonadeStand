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
        double paidAmount;
        public void StartGame()
        {
            StartIntro();
            GatherInfo();
            SetFinites();
            playerEins.MoneyProblems();           
            DayByDayLoop();
            ShowFinalProfit();
            EndGame();                       
        }
        private void EndGame()
        {
            string finaleChoice;
            Console.WriteLine("Would you like to play again?");
            finaleChoice = Console.ReadLine().ToLower();
            switch (finaleChoice)
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    break;
                default:
                    EndGame();
                    break;
                }
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
                GetPitcherCount();
                UseFirstPitcher();               
                GenerateClients();
                RunDay();
                MoneyAdding();
                Prof();
                PlusDay();
                MeltIce();
                RestoreBalance();
                GotPaid();
            }
        }

        private void RestoreBalance()
        {
            playerEins.RestoreBalance();
        }

        private void UseFirstPitcher()
        {
            playerEins.UseFirstPitcher();
        }

        private void MeltIce()
        {
            playerEins.MeltIce();
            Console.WriteLine("The rest of your ice has melted");
        }

        private void DisplayDay()
        {
            Console.WriteLine("\nIt is Day: " + (dayCount + 1));
        }
        private void PlusDay()
        {
            dayCount++;
        }
        private void GetPitcherCount()
        {
            playerEins.GetMaxPitchers();           
        }
        public void Prof()
        {
            netProfit = (paidAmount + (playerEins.ReturnLoss()));
            Console.WriteLine("Your running profit total is "+netProfit+" Dollars");
        }           
        private void ShowFinalProfit()
        {
            Prof();
        }
        private void MoneyAdding()
        {
            
            dollaBils = (cupsBought * playerEins.MoneyRecipe());
            Console.WriteLine("You have made "+dollaBils+" dollars today.");
            paidAmount = (paidAmount + dollaBils);

        }
        private void RunDay()
        {
            Console.WriteLine("This many were cups bought");
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
                            if ((cupsBought >= 1) && (cupsBought % 12 == 0) && (playerEins.CheckPitchers() > 0))
                            {
                                playerEins.UsePitcher();
                            }
                            else if (playerEins.CheckPitchers() == 0)
                            {
                                cupsBought = cupsBought - 1;
                                break;
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
            
            Console.WriteLine("The current Weather is: "+ day.GrabWeather() + ", and the Temperature is: " + day.GrabTemp() + " Degrees");
            day.ShowWeatherBonus();
        }
        private void SetFinites()
        {
            Console.WriteLine("The Predicted Weather for the week is:");
            Console.WriteLine("Sunday: "+day.CreateWeather()+", Monday: "+day.CreateWeather()+", Tuesday: "+day.CreateWeather()+", Wednesday: "+day.CreateWeather()+", Thursday: "+day.CreateWeather()+", Friday: "+day.CreateWeather()+", Saturday: "+day.CreateWeather());
            Console.WriteLine("Your Begining Balance is : " + playerEins.CreateMoney() + " Dollars");
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
            Console.WriteLine("There are 12 cups per Pitcher");
        }
        public double MoneyObtained()
        {
            return dollaBils;
        }
        public void GotPaid()
        {
            playerEins.currentMoney = (MoneyObtained() + playerEins.currentMoney);
        }
    }
}
