using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player playerEins = new LemonadeStand.Player();
        
        public void StartGame()
        {
            StartIntro();
            GatherInfo();
            SetFinites();
            DayByDayLoop();
            ShowFinalProfit();            
        }
        private void DayByDayLoop()
        {
            GenerateSetting();
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
            throw new NotImplementedException();
        }
        private void GenerateClients()
        {
            throw new NotImplementedException();
        }
        private void CheckInventory()
        {
            throw new NotImplementedException();
        }
        private void GetRecipe()
        {
            throw new NotImplementedException();
        }
        private void GenerateSetting()
        {
            Weather day = new LemonadeStand.Weather();
            Console.WriteLine("The Current Weather Is: "+ day.GrabWeather() + " And the Temperature is: " + day.GrabTemp() + " Degrees");
        }
        private void SetFinites()
        {
            Console.WriteLine("The Predicted Weather for the week is:");
            Console.WriteLine("Sunday: , Monday: , Tuesday: , Wednesday: , Thursday: , Friday: , Saturday: ");
            Console.WriteLine("Your Begining Balance is : " + playerEins.CreateMoney() + "Dollars" );
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
