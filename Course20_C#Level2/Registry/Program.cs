using System;
using System.Globalization;
using Microsoft.Win32;

namespace Registry_Section
{
	internal class Program
	{
		static public void WriteOnRegistry(string keyPath,string valueName ,string value)
		{
			try
			{
				Registry.SetValue(keyPath, valueName, value,RegistryValueKind.String);
				
				Console.WriteLine("Write on registry done successfuly ..!");

			}catch(Exception Ex) 
			{
				Console.WriteLine(Ex.Message);
			}
		}

		static public string ReadFromRegistry(string KeyPath,string valeName)
		{
			try
			{
				return Registry.GetValue(KeyPath,valeName,null) as string;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			return null;
		}
		static void Main(string[] args)
		{
			string keyPath = @"HKEY_CURRENT_USER\Software\TrainginKey";

			string valueName = "UserName";
			string value = "MohammedJihadAlsmadi";

			//WriteOnRegistry(keyPath, valueName, value);

			//Console.WriteLine(ReadFromRegistry(keyPath,valueName)); 

			WriteOnRegistry(@"HKEY_LOCAL_MACHINE\SOFTWARE", "YourValueName", "YourValueData");


			Console.ReadKey();
		}
	}
}
