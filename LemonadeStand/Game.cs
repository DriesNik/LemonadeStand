using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void StartGame()
        {
            StartIntro();
            GatherInfo();
            SetFinites();
            ShowFinalProfit();
            DayByDayLoop();
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
        private void SetFinites()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        private void GatherInfo()
        {
            throw new NotImplementedException();
        }
        private void StartIntro()
        {
            throw new NotImplementedException();
        }
    }
}
