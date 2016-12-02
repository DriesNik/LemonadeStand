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
        Player playerEins = new Player();
        Weather day = new LemonadeStand.Weather();
        
        public int cupsBought;
        public void StartGame()
        {
            StartIntro();
            GatherInfo();
            SetFinites();
            Thread.Sleep(1000);
            DayByDayLoop();
            ShowFinalProfit();            
        }
        private void DayByDayLoop()
        {
            GenerateSetting();
            Thread.Sleep(2000);
            GetRecipe();
            CheckInventory();
            GenerateClients();
            RunDay();
            MoneyAdding();
        }     
           
        private void ShowFinalProfit()
        {
            throw new NotImplementedException();
        }
        private void MoneyAdding()
        {
            throw new NotImplementedException();
        }
        private void RunDay()
        {
            Console.WriteLine("this many cups bought");
            Console.WriteLine(cupsBought);
        }
        private void GenerateClients()
        {
            int i;
            cupsBought = 0;
            for (i = 1; i < 100; i++)
            {
                Ai Dude = new Ai(day, playerEins);

                switch (Dude.DidTheyBuy())
                {
                    case 1:
                        UpCup();
                        break;
                    default:
                        break;
                }

            }
            //throw new NotImplementedException();
        }
        private void CheckInventory()
        {
            //throw new NotImplementedException();
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
