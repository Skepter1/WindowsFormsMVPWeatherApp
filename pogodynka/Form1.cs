using System.ComponentModel;

namespace pogodynka
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCapitals();
        }

        private void InitializeCapitals()
        {
            string[] stolice = {
                "Warszawa", "Berlin", "Paryż", "Londyn", "Madryt",
                "Rzym", "Wiedeń", "Praga", "Ateny", "Lizbona",
                "Sztokholm", "Oslo", "Kopenhaga", "Bruksela", "Amsterdam",
                "Budapeszt", "Bukareszt", "Sofia", "Helsinki", "Dublin"
            };
            comboBoxStolica.Items.AddRange(stolice);
            comboBoxStolica.SelectedIndex = 0; // Ustawia domyślnie pierwszą stolicę
        }

        public event Action CheckWeather;


        public string CityName {
            get {
                if (comboBoxStolica.SelectedIndex == 0)
                {
                    return textBoxNazwaMiasta.Text;
                }
                else
                {
                    return comboBoxStolica.SelectedItem.ToString();
                }
            }
        }


        public string Temperature
        {
            set { textBoxTemperatura.Text = value; }
        }


        public string Pressure
        {
            set { textBoxCisnienie.Text = value; }
        }

        public string Humidity
        {
            set { textBoxWilgotnosc.Text = value; }
        }

        public string WindSpeed
        {
            set { textBoxPredkoscWiatru.Text = value; }
        }

        public string Max_temperature
        {
            set { textBoxMaxTemperature.Text = value; }
        }

        public string WeatherIconUrl
        {
            set { pictureBoxIcon.LoadAsync(value); }
        }
        public string CityNotFoundMessage
        {
            set { labelCityNotFound.Text = value; }
        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            CheckWeather?.Invoke();
        }
    }
}
