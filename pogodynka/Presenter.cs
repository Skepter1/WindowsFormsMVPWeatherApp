using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pogodynka
{
    internal class Presenter
    {
        private readonly IView _view;
        private Model _model;

        public Presenter(Model model, IView view)
        {
            _model = model;
            _view = view;
            _view.CheckWeather += OnGetWeatherClicked;
        }

        private async void OnGetWeatherClicked()
        {
            string city = _view.CityName;
            var weather = await _model.GetWeatherAsync(city);

            if (weather != null)
            {
                if (weather.cod != "200")
                {
                    _view.CityNotFoundMessage = "Nie znaleziono miasta. Sprawdź nazwę i spróbuj ponownie.";
                    _view.Temperature = "";
                    _view.Pressure = "";
                    _view.Humidity = "";
                    _view.WindSpeed = "";
                    _view.Max_temperature = "";
                    return;
                }
                _view.CityNotFoundMessage = "";
                _view.Temperature = $"{weather.main.temp} °C";
                _view.Pressure = $"{weather.main.pressure} hPa";
                _view.Humidity = $"{weather.main.humidity} %";
                _view.WindSpeed = $"{weather.wind.speed} m/s";
                _view.Max_temperature = $"{weather.main.temp_max} °C";
                string iconCode = weather.weather[0].icon;
                string url = $"https://openweathermap.org/img/wn/{iconCode}@2x.png";
                _view.WeatherIconUrl = url;
            }
        }
    }
}
