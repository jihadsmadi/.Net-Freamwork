using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ContactDataAccessLayer;

namespace ContactBusinessLayer
{
	public class clsContacts
	{

		public int ID { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Adress { get; set; }

		public int CountryID { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string ImagePath { get; set; }


		public clsContacts(int Id,string FirstName,string LastName, string Email,
									 string Phone,string Address,int CountryID,DateTime DateOfBirth,string ImagePath)
		{
			this.ID = Id;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Email = Email;
			this.Phone = Phone;
			this.Adress  = Address;
			this.CountryID = CountryID;
			this.DateOfBirth = DateOfBirth;
			this.ImagePath = ImagePath;


		}
		public static clsContacts Find(int ID)
		{
			string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
			int CountryID = -1;
			DateTime DateOfBirth = DateTime.Now;


			if(clsContactDataAccessLayer.GetContactInfo(ID,ref FirstName,ref LastName,ref Email,ref Phone,ref Address,
								ref CountryID,ref DateOfBirth,ref ImagePath))
			{
				return new clsContacts(ID,FirstName,LastName,Email,Phone,Address,CountryID,DateOfBirth,ImagePath);
			}
			else
			{
				return null;
			}



		}


	}
}
