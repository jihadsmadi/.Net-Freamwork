using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ApiTrayning
{
	public partial class frmGetCity : Form
	{
		private Country _country;
		public string CountryURL = "https://countriesnow.space/api/v0.1/countries";
		private List<String> CountryList= new List<String>();
		public string Country = "";
		public string City = "";
		public frmGetCity()
		{
			InitializeComponent();
		}

		private void LoadCountry(string url)
		{
			HttpHelper helper = new HttpHelper();
			var data  = helper.ConvertToJson(url);
			_country = Newtonsoft.Json.JsonConvert.DeserializeObject<Country>(data);
		}

		private async void frmGetCity_Load(object sender, EventArgs e)
		{
			await Task.Run(() => LoadCountry(CountryURL));
			await Task.Run(() => SetData());

			cbLocation.DataSource = CountryList;


		}

		public string GetFullCountry()
		{
			return Country + ", " + City;
		}
		private void SetData()
		{
			for (int i = 0; i < _country.data.Length; i++)
			{
				Country = _country.data[i].country;
				for(int j = 0; j < _country.data[i].cities.Length; j++)
				{
					City = _country.data[i].cities[j];
					CountryList.Add(GetFullCountry());
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.CountryFullName = cbLocation.Text;
			Properties.Settings.Default.Save();
			this.Close();
			
		}
	}
}
