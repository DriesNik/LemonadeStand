using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        Weather Day;       
        public Player(Weather day, Inventory barn)
        {
            Day = day;            
        }

        

        string name;
        double beginMoney;
        double sellingPower;
        double recipeLemon;
        double recipeSugar;
        double recipeIce;
        double recipeMoney;
        double inventLemons;
        double inventSugar;
        double inventIce;
        double currentMoney;
        double maxPitchers;
        double runningTotal;
        public void BaseItems()
        {
            inventLemons = 0;
            inventSugar = 0;
            inventIce = 0;
        }
        public void MoneyProblems()
        {
            currentMoney = beginMoney;
        }
        public void MoneyForLemons()
        {
           currentMoney = ( currentMoney - 0.20);
            runningTotal = (runningTotal - 0.20);
        }
        public void MoneyForSugar()
        {
            currentMoney = (currentMoney - 0.15);
            runningTotal = (runningTotal - 0.15);
        }
        public void MoneyForIce()
        {
            currentMoney = (currentMoney - 0.10);
            runningTotal = (runningTotal - 0.10);
        }
        public void AddLemons()
        {
            inventLemons++;
        }
        public void AddSugar()
        {
            inventSugar++;
        }
        public void AddIce()
        {
            inventIce++;
        }
        public void GetMaxPitchers()
        {            
               maxPitchers = (Math.Min((inventLemons / recipeMoney), Math.Min((inventSugar / recipeSugar), (inventIce / recipeIce)))-1);            
        }
        public double CheckPitchers()
        {
            return maxPitchers;
        }       
        public double ReturnLemon()
        {
            return inventLemons;
        }
        public double ReturnSugar()
        {
            return inventSugar;
        }
        public double ReturnIce()
        {
            return inventIce;
        }
        public string GrabName()
        {
            Console.WriteLine("Please enter Your Name");
            name = Console.ReadLine();
            return name;
        }
        public void MakeRecipe()
        {
            try
            {
                Console.WriteLine("How many lemons per pitcher?");
                recipeLemon = int.Parse(Console.ReadLine());
                Console.WriteLine("How many sugars per pitcher?");
                recipeSugar = int.Parse(Console.ReadLine());
                Console.WriteLine("How much ice per pitcher?");
                recipeIce = int.Parse(Console.ReadLine());
                Console.WriteLine("How much would you like to charge per cup? 0.01 cents to 1.00 dollar");
                recipeMoney = (double.Parse(Console.ReadLine()));
            }
            finally
            {
                Console.WriteLine("Time to start the day");
            }
            
        }
        public double MoneyBonus()
        {
            if (recipeMoney <1)
            {
                return 5;
            }
            else if (recipeMoney < 0.75)
            {
                return 4;
            }
            else if (recipeMoney < 0.5)
            {
                return 3;
            }
            else if (recipeMoney <0.35)
            {
                return 2;
            }
            else if (recipeMoney == 0.35)
            {
                return 0;
            }
            else if (recipeMoney > 0.10)
            {
                return -2;
            }
            else if (recipeMoney > 0.35)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        public double LemonBonus()
        {
            int bonusLemon;
            if (recipeLemon == 7)
            {
                bonusLemon = 5;
                return bonusLemon;
            }
            else if (recipeLemon <= 4 || recipeLemon >= 10)
            {
                bonusLemon = 0;
                return bonusLemon;
            }
            else if (recipeLemon <= 6 || recipeLemon >= 8)
            {
                bonusLemon = 3;
                return bonusLemon;
            }
            else
            {
                bonusLemon = -3;
                return bonusLemon;
            }
        }
        public double SugarBonus()
        {
            int bonusSugar;
            if (recipeSugar == 6)
            {
                bonusSugar = 5;
                return bonusSugar;
            }
            else if (recipeSugar <= 3 || recipeSugar >= 9)
            {
                bonusSugar = 0;
                return bonusSugar;
            }
            else if (recipeSugar <= 5 || recipeSugar >= 7)
            {
                bonusSugar = 3;
                return bonusSugar;
            }
            else
            {
                bonusSugar = -3;
                return bonusSugar;
            }
        }
        public double IceBonus()
        {
            int bonusIce;
            if (recipeIce == 8)
            {
                bonusIce = 5;
                return bonusIce;
            }
            else if (recipeIce <= 5 || recipeIce >= 11)
            {
                bonusIce = 0;
                return bonusIce;
            }
            else if (recipeIce <= 7 || recipeIce >= 9)
            {
                bonusIce = 3;
                return bonusIce;
            }
            else
            {
                bonusIce = -3;
                return bonusIce;
            }
        }
        public double CreateMoney()
        {
            Random r = new Random();
            beginMoney = r.Next(20, 100);
            return beginMoney;
        }
        public double GetWB()
        {  
            return Day.weatherBonus;
        }
        public double TempBonus()
        {
            if (Day.GrabTemp() >90)
            {
                return 5;
            }
            else if(Day.GrabTemp() > 80)
            {
                return 4;
            }
            else if (Day.GrabTemp() > 70)
            {
                return 3;
            }
            else if (Day.GrabTemp() > 60)
            {
                return 2;
            }
            else
            {
                return 0;
            }

        }
        public double PowerToSell()
        {
            sellingPower = (((GetWB() + LemonBonus() + IceBonus() + SugarBonus() + TempBonus())-MoneyBonus()) * 5);
            return sellingPower;
        }
        public double MoneyRecipe()
        {
            return recipeMoney;
        }
        public double GetMoney()
        {
            return currentMoney;
        }
        public void UsePitcher()
        {
            maxPitchers = (maxPitchers - 1);
            inventLemons = inventLemons - recipeLemon;
            inventSugar = inventSugar - recipeSugar;
            inventIce = inventIce - recipeIce;
        }
        public double ReturnLoss()
        {
            return runningTotal;
        } 
    }
}
