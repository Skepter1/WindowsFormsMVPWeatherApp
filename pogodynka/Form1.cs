using System.ComponentModel;

namespace pogodynka
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }
        public event Action CheckWeather;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CityName => textBoxNazwaMiasta.Text;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Temperature
        {
            set { textBoxTemperatura.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            CheckWeather?.Invoke();
        }
        
    }
}
