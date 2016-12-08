using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random r = new Random();
        public string weatherType;
        public int temp;
        public double weatherBonus;

        public string CreateWeather()
        {
            int potentialWeather;
            Thread.Sleep(r.Next(5));
            potentialWeather = r.Next(6);
            switch(potentialWeather)
            {
                case 1:
                    weatherType = "Cloudy";
                    break;
                case 2:
                    weatherType = "Sunny";
                    break;
                case 3:
                    weatherType = "Raining";
                    break;
                case 4:
                    weatherType = "Hot";
                    break;
                case 5:
                    weatherType = "Usual Wisconsin";
                    break;
                case 6:
                    weatherType = "Boiling";
                    break;
                default:
                    CreateWeather();
                    break;
            }
            return weatherType;

        }

        public double ShowWeatherBonus()
        {
            if (weatherType == "Boiling")
            {
                weatherBonus = 5;
                    return weatherBonus;
            }
            else if (weatherType == "Hot")
            {
                weatherBonus = 4;
                    return weatherBonus;
            }
            else if (weatherType == "Sunny")
            {
                weatherBonus = 3;
                return weatherBonus;
            }
            else if (weatherType == "Cloudy")
            {
                weatherBonus = 2;
                return weatherBonus;
            }
            else if (weatherType == "Raining")
            {
                weatherBonus = 1;
                return weatherBonus;
            }
            else if ( weatherType == "Usual Wisconsin")
            {
                weatherBonus = -1;
                return weatherBonus;
            }
            else
            {
                weatherBonus = 0;
                return weatherBonus;
            }
        }

        public void CreateTemp()
        {
          temp = r.Next(60, 99);
        }

        public int GrabTemp()
        {
            CreateTemp();
            return temp;
        }

        public string GrabWeather()
        {
            CreateWeather();
            return weatherType;
        }
    }
}
