using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        Random r = new Random();
        public string weatherType;
        public int temp;
        public void CreateWeather()
        {
            int potentialWeather;
            
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
