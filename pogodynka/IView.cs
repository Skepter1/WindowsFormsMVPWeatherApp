using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogodynka
{
    internal interface IView
    {
        string CityName { get; }
        string Temperature { set; }
        string Pressure { set; }
        string Humidity { set; }
        string WindSpeed { set; }
        string Max_temperature { set; }
        string WeatherIconUrl { set; }
        string CityNotFoundMessage { set; }

        event Action CheckWeather;
    }
}
