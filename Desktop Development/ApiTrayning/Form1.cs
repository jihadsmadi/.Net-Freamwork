using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;

namespace ApiTrayning
{
	public partial class frmMain : Form
	{
		string URL;
		string CountryFullName;
		WeatherData _weather;
		public frmMain()
		{
			InitializeComponent();
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frmGetCity frmGetCity = new frmGetCity();
			frmGetCity.Show();
		}


		private async void frmMain_Load(object sender, EventArgs e)
		{
			CountryFullName = Properties.Settings.Default.CountryFullName;
			await Task.Run(() => LoadWeatherData());
			SetData();
		}

		private  void LoadWeatherData()
		{
			string URL = "http://api.weatherapi.com/v1/current.json?key=83731dfa3e7b43acade95901230306&q=" + CountryFullName;
			HttpHelper helper = new HttpHelper();
			var data = helper.ConvertToJson(URL);
			_weather = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherData>(data);
		}

		private void SetData()
		{
			lbTimeNow.Text = DateTime.Now.ToString("hh:mm:ss");
			lpTodayDate.Text = DateTime.Now.ToString("M:MMMM:yyyy");
			lbTempreatre.Text = _weather.current.temp_c.ToString()+"C";
			lbWaterPresantage.Text = _weather.current.humidity.ToString() + "%";
			lbWindSpeed.Text = _weather.current.wind_kph.ToString() + "Km / h";
			lbWheatherState.Text = _weather.current.condition.text;
			lbCountry.Text = _weather.location.name;
			lbCity.Text = _weather.location.country;
			pbWheaterState.ImageLocation = _weather.current.condition.icon;
		}

		private async void pictureBox4_Click(object sender, EventArgs e)
		{
			CountryFullName = Properties.Settings.Default.CountryFullName;
			await Task.Run(() => LoadWeatherData());
			SetData();
		}
	}
}
