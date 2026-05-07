using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace pogodynka
{
    public class Model
    {
        private readonly string apiKey = System.Configuration.ConfigurationManager.AppSettings["OpenWeatherApiKey"];  

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
                try
                {
                    var response = await client.GetStringAsync(url);
                    var data = JsonConvert.DeserializeObject<WeatherData>(response);
                    return data;
                }
                catch (Exception ex) { 
                    return new WeatherData { cod = "404" };
                }

            }
        }
    }
}
