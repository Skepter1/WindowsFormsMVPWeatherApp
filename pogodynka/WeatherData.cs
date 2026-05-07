using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogodynka
{
    public class WeatherData
    {
        public MainData main { get; set; }
        public WeatherDescription[] weather { get; set; }
        public Wind wind { get; set; }
        public string cod { get; set; }
        public string name { get; set; }
    }

    public class MainData
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }

    public class WeatherDescription
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}
