
using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using ContactBusinessLayer;
using ContactsBusinessLayer;

namespace ContactsConsolApp
{
    internal class Program
    {
        static void testFindContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName + " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");
            }
        }

        static void testAddNewContact()
        {
            clsContact contact = new clsContact();

            contact.FirstName = "Test";
            contact.LastName = "Test";
            contact.Email = "Test@gmail.com";
            contact.Phone = "0999999999";
            contact.Address = "Test";
            contact.ImagePath = "Test.jpg";
            contact.CountryID = 1;
            contact.DateOfBirth = DateTime.Now;


            if (contact.Save())
            {
                Console.WriteLine("Contact Added Successfully");
            }
            else
            {
                Console.WriteLine("Contact Added Faild");
            }
        }

        static void testUpdateContact(int ID)
        {
            clsContact contact = clsContact.Find(ID);

            if (contact != null)
            {
                contact.FirstName = "Update2";
                contact.LastName = "Smadi";
                contact.Email = "Test";
                contact.Phone = "Test";
                contact.Address = "Test";
                contact.ImagePath = "";
                contact.CountryID = 1;
                contact.DateOfBirth = DateTime.Now;

                if (contact.Save())
                {
                    Console.WriteLine("Contact Updated Successfully  ");
                }
                else
                {

                    Console.WriteLine("Contact Updated Faild  ");
                }
            }
            else
            {

                Console.WriteLine("Contact Dose not Found  ");
                return;
            }
        }

        static void testDeleteContact(int ID)
        {

			if (clsContact.IsContactExist(ID))
			{
				if (clsContact.Delete(ID))
				{
					Console.WriteLine("Contact Deleted Successfully ");
				}
				else
				{
					Console.WriteLine("Contact Deleted Faild");
				}
			}
			else
			{
				Console.WriteLine("Contact Is Not Found");
			}

		
        }

        static void ListContacts()
        {
            DataTable dataTable = clsContact.GetContactList();

            Console.WriteLine("Contact List");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}, {row["FirstName"]} {row["LastName"]}");
            }
        }

        static void testIsContactExist(int ID)
        {
            if(clsContact.IsContactExist(ID))
            {
                Console.WriteLine("Contact Is Found");
            }
            else
            {
                Console.WriteLine("Contact Is Not Found");
            }
        }


        //Countries
        
        static void testFindCountryByID(int ID)
        {
            Country country = Country.Find(ID);

            if(country != null)
            {
                Console.WriteLine("Country Data");
                Console.WriteLine($"Country ID: {country.CountryID}, Country Name: {country.CountryName}");
            }
            else
            {
                Console.WriteLine("Country With ["+ID+"] Is Not Found");
            }
        }

		static void testFindCountryByName(string CountryName)
		{
			Country country = Country.Find(CountryName.Trim());

			if (country != null)
			{
				Console.WriteLine("Country Data");
				Console.WriteLine($"Country ID: {country.CountryID}, Country Name: {country.CountryName}");
			}
			else
			{
				Console.WriteLine("[" + CountryName + "] Is Not Found");
			}
		}

        static void testAddNewCountry()
        {
            Country country = new Country();
            country.CountryName = "Spain";
            country.Code = "333";
            country.phoneCode = "963";

            if (country.Save())
            {
                Console.WriteLine("Country["+country.CountryID+"] Saved Successfully ...!");
            }
            else
            {
                Console.WriteLine("Country Saved Faild ....!");
            }
        }

        static void testUpdateCountry(int ID)
        {
            Country country = Country.Find(ID);

            if (country != null)
            {
                country.CountryName = "Update Test";
                country.Code = "666";
                country.phoneCode = "123";

                if(country.Save())
                {
                    Console.WriteLine("Country Updated Successfully ...!");
                }
                else
                {
                    Console.WriteLine("Country Updated Faild");
                }
            }
            else
            {
                Console.WriteLine("Country With ["+ID+"] Dose Not Found ");
            }
        }

        static void testDeleteCountry(int ID)
        {
            if(clsContact.Delete(ID))
            {
                Console.WriteLine("Country Deleted Successfully ...!");
            }
            else
            {
                Console.WriteLine("Country Deleted Faild ...!");
            }
        }

        static void testCountryList()
        {
            DataTable dataTable = Country.GetCountriesList();


			Console.WriteLine("Countries List");
			foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"Country ID {row["CountryID"]}, Country Name {row["CountryName"]}, Code {row["Code"]}, Phone Code = {row["PhoneCode"]}");
            }
        }

        static void testIsCountryExist(string CountryName)
        {
            if(Country.IsExist(CountryName.Trim()))
            {
                Console.WriteLine($"{CountryName} Is Exist ");
            }
            else
            {
                Console.WriteLine("Country Dose Not Exist ...!");
            }
        }
		static void Main(string[] args)
        {

			//testFindContact(1);
			//testAddNewContact();
			//testUpdateContact(1);
			//ListContacts();
			//testDeleteContact();
			//testIsContactExist(100);

			//testFindCountryByID(6);
			//testFindCountryByName("Germany");
			//testAddNewCountry();
			//testUpdateCountry(6);
			//testDeleteCountry(6);
			//testCountryList();

			//testIsCountryExist("Germany");


			Console.ReadKey();

        }
    }
}
