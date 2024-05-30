using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
	public class Country
	{

		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public int CountryID { get; set; }

		public string CountryName { get; set; }

		public string Code { get; set; }

		public string phoneCode { get; set; }

		public Country()
		{
			this.CountryID = -1;
			this.CountryName = "";
			this.Code = "";
			this.phoneCode = "";

			this.Mode = enMode.AddNew;
		}
		private Country(int ID,string CountryName,string Code,string PhoneCode)
		{
			this.CountryID= ID;
			this.CountryName= CountryName;
			this.Code = Code;
			this.phoneCode= PhoneCode;

			this.Mode = enMode.Update;
		}
		public static Country Find(int CountryID)
		{
			string _CountryName = "";
			string _Code = "";
			string _phoneCode = "";

			if(CountriesData.GetCountryByCountryID(CountryID,ref _CountryName,ref _Code,ref _phoneCode))
			{
				return new Country(CountryID, _CountryName,_Code,_phoneCode);
			}
			else
			{
				return null;
			}

			
		}


		public static Country Find(string CountryName)
		{
			int _CountryID = -1;
			string _Code = "";
			string _phoneCode = "";


			if (CountriesData.GetCountryByCountryName(ref _CountryID, CountryName ,ref _Code, ref _phoneCode))
			{
				return new Country(_CountryID, CountryName,_Code,_phoneCode);
			}
			else
			{
				return null;
			}


		}

		private bool _AddNew()
		{
			this.CountryID = CountriesData.AddNewCountry(this.CountryName,this.Code,this.phoneCode);

			return (this.CountryID != -1);

		}

		private bool _Update()
		{
			return CountriesData.UpdateCountry(this.CountryID,this.CountryName,this.Code,this.phoneCode);
		}


		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:

					if(_AddNew())
					{
						this.Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}
				case enMode.Update:

					return _Update();
					

					

					break;
				default:
					break;
			}

			return false;
		}

		public static bool Delete(int CountryID)
		{
			return CountriesData.DeleteCountry(CountryID);
		}

		public static DataTable GetCountriesList()
		{
			return CountriesData.CountriesList();			
		}

		public static bool IsExist(string CountryName)
		{
			return CountriesData.IsCountryExist(CountryName);
		}



	}
}
