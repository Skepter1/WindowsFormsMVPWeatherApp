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
            string city = _view.CityName; // Pobierz z TextBoxa przez interfejs
            var weather = await _model.GetWeatherAsync(city); // Pobierz z API przez Model

            if (weather != null)
            {
                _view.Temperature = $"{weather.main.temp} °C"; // Wyślij do Labela przez interfejs
                _view.Pressure = $"{weather.main.pressure} hPa";
                _view.Humidity = $"{weather.main.humidity} %";
                _view.WindSpeed = $"{weather.main.wind} m/s";
                _view.Visibility = $"{weather.main.visibility}";

                // Tutaj też ustawisz ikonę na podstawie weather.weather[0].icon
            }
        }
    }
}
