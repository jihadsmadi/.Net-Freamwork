using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;
using ContactBusinessLayer;

namespace ContactPresentationLayer
{
	public class Program
	{

		static void PrintContactInfo(clsContacts contact)
		{

			Console.WriteLine($"Contact ID    = {contact.ID}");
			Console.WriteLine($"Name          = {contact.FirstName + " "+ contact.LastName }");
			Console.WriteLine($"Email         = {contact.Email}");
			Console.WriteLine($"Phone         = {contact.Phone}");
			Console.WriteLine($"Address       = {contact.Adress}");
			Console.WriteLine($"Country ID    = {contact.CountryID}");
			Console.WriteLine($"Date Of Birth = {contact.DateOfBirth.ToString()}");
			Console.WriteLine($"Image Path    = {contact.ImagePath}");
			Console.WriteLine("----------------------------");
		}
		static void TestFindContacts(int id)
		{
			clsContacts Contact1 = clsContacts.Find(id);

			if(Contact1 != null)
			{
				PrintContactInfo(Contact1);
			}
			else
			{
				Console.WriteLine("Contact ["+id+"] Not Found ....!");
			}
		}



		static void Main(string[] args)
		{
			TestFindContacts(100);

			Console.ReadKey();

		}
	}
}
