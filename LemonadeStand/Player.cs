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
        public Player(Weather day)
        {
            Day =  day;
            
        }

        public Player()
        {
        }

        string name;
        int beginMoney;
        double sellingPower;
        int recipeLemon;
        int recipeSugar;
        int recipeIce;
        public string GrabName()
        {
            Console.WriteLine("Please enter Your Name");
            name = Console.ReadLine();
            return name;
        }
        public void MakeRecipe()
        {
            Console.WriteLine("how many lemons");
            recipeLemon = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sugars");
            recipeSugar = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Ices");
            recipeIce = int.Parse(Console.ReadLine());
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
        public int CreateMoney()
        {
            Random r = new Random();
            beginMoney = r.Next(20, 100);
            return beginMoney;
        }
        public double GetWB()
        {
            
            Day.ShowWeatherBonus();
            return Day.ShowWeatherBonus();
        }
        public double PowerToSell()
        {
            sellingPower = ((GetWB() + LemonBonus() + IceBonus() + SugarBonus())* (3.75));
            return sellingPower;
        }
    }
}
