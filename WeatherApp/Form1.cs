using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ApiKey = "0d19fd28ca6032a3d9a6752159d25755";

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void handleSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
        }
        public void GetWeather()
        {
            using (WebClient web = new WebClient()) {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBox1.Text, ApiKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon +".png";
                condition.Text = Info.weather[0].main;
                details.Text = Info.weather[0].description;
                sunset.Text = Info.sys.sunset.ToString();
                sunrise.Text = Info.sys.sunrise.ToString();
                windSpeed.Text = Info.wind.speed.ToString();
                pressure.Text = Info.main.pressure.ToString();  

            }
        }
    }
}
